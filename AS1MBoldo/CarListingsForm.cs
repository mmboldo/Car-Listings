using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace AS1MBoldo
{
    public partial class CarListingsForm : Form
    {
        List<Car> allCars = new List<Car>();

        public CarListingsForm()
        {
            InitializeComponent();
           
            // Initializing Data Grid View controls
            InitializeDataGridViews();

            // OpenFileDialog
            OpenFileDialog openFileDialogXML = new OpenFileDialog
            {
                InitialDirectory = Path.GetFullPath(Application.StartupPath + "\\..\\.."),
                Filter = "XML files|*.xml"
            };

            // open the file dialog, get a file name, and open the file
            if (openFileDialogXML.ShowDialog() == DialogResult.OK)
            {
                // could use new StreamReader() here as well
                StreamReader carsInventory = new StreamReader(openFileDialogXML.FileName);

                // Xml Serializer
                XmlSerializer allCarsSerializer =
                    new XmlSerializer(typeof(List<Car>), new XmlRootAttribute("ArrayOfCar"));

                // Deserializing the xml file
                allCars = allCarsSerializer.Deserialize(carsInventory) as List<Car>;

                // closing the Stream Reader
                carsInventory.Close();
            }
            else return;
            
            // Setting all controls to default
            ResetToDefaults();

            // event handlers for the checkboxes
            checkBoxPrice.CheckedChanged += DisplayAll;
            checkBoxEngineSize.CheckedChanged += DisplayAll;

            // Button click event for the reset filters button
            buttonResetFilters.Click += (s, e) => ResetToDefaults();

            // If the textbox has changed, and the checkbox is still checked, then redisplay students
            textBoxMinPriceFilter.TextChanged += (s, e) => { if (checkBoxPrice.Checked) { DisplayAll(); } };
            textBoxMaxPriceFilter.TextChanged += (s, e) => { if (checkBoxPrice.Checked) { DisplayAll(); } };

            textBoxMinEngineSizeFilter.TextChanged += (s, e) => { if (checkBoxEngineSize.Checked) { DisplayAll(); } };
            textBoxMaxEngineSizeFilter.TextChanged += (s, e) => { if (checkBoxEngineSize.Checked) { DisplayAll(); } };

            // if the textboxes for price have changed, and the checkbox is still checked, then redisplay students
            dataGridViewAllCars.CellValueChanged += (s, e) => ResetToDefaults();
        }

        /// <summary>
        /// Resets Data Grid Views, Listboxes, Checkboxes and Textboxes to their defaults
        /// </summary>
        private void ResetToDefaults()
        {
            InitializeListBoxes();

            // unregistering the listboxes event handlers
            listBoxMakesFilter.SelectedIndexChanged -= DisplayAll;
            listBoxYearsFilter.SelectedIndexChanged -= DisplayAll;
            listBoxColorsFilter.SelectedIndexChanged -= DisplayAll;
            listBoxDealersFilter.SelectedIndexChanged -= DisplayAll;

            // setting all of the listbox MAKES selected
            for (int i = 0; i < listBoxMakesFilter.Items.Count; i++)
            {
                listBoxMakesFilter.SetSelected(i, true);
            }

            // setting all of the listboxes YEARS selected
            for (int i = 0; i < listBoxYearsFilter.Items.Count; i++)
            {
                listBoxYearsFilter.SetSelected(i, true);
            }

            // setting all of the listboxes COLORS selected
            for (int i = 0; i < listBoxColorsFilter.Items.Count; i++)
            {
                listBoxColorsFilter.SetSelected(i, true);
            }

            // setting all of the listboxes DEALERS selected
            for (int i = 0; i < listBoxDealersFilter.Items.Count; i++)
            {
                listBoxDealersFilter.SetSelected(i, true);
            }

            // clearing ann the checkboxes and associated text
            checkBoxPrice.Checked = false;
            checkBoxEngineSize.Checked = false;
            textBoxMinPriceFilter.Clear();
            textBoxMaxPriceFilter.Clear();
            textBoxMinEngineSizeFilter.Clear();
            textBoxMaxEngineSizeFilter.Clear();

            // redisplaying all cars, with every listBox filters selected
            DisplayAll();

            // registering the listboxes event handlers again
            listBoxMakesFilter.SelectedIndexChanged += DisplayAll;
            listBoxYearsFilter.SelectedIndexChanged += DisplayAll;
            listBoxColorsFilter.SelectedIndexChanged += DisplayAll;
            listBoxDealersFilter.SelectedIndexChanged += DisplayAll;
        }

        /// <summary>
        /// Given selected makes, years, color and engine sizes from listBoxes, 
        /// and minimum and maximum values for price and engine size (if respective
        /// checkboxes are checked, filters the cars).<br/>
        /// After that, displays statistics - number of cars and average price
        /// </summary>
        public void DisplayAll(object sender = null, EventArgs e = null)
        {
            // Check if the Price checkbox is checked.
            // If so, get min and max values.
            int minPrice = 0;
            int maxPrice = 0;
            
            // this block is started only if the checkbox is checked
            if (checkBoxPrice.Checked == true)
            {
                try
                {   // This block tried to convert the text of each text boxes into decimal numbers
                    minPrice = int.Parse(textBoxMinPriceFilter.Text);
                    maxPrice = int.Parse(textBoxMaxPriceFilter.Text);
                }
                catch (FormatException)
                {   // An exception is thrown, and a message is displayed if they are empty or in the wrong format
                    MessageBox.Show("Price is missing or not an integer!");
                    checkBoxPrice.Checked = false;
                }
            }

            // Check if the Engine Size checkbox is checked.
            // If so, get min and max values.
            decimal minEngineSize = 0;
            decimal maxEngineSize = 0;

            // this block is started only if the checkbox is checked
            if (checkBoxEngineSize.Checked == true)
            {
                try  
                {   // This block tried to convert the text of each text boxes into decimal numbers
                    minEngineSize = decimal.Parse(textBoxMinEngineSizeFilter.Text);
                    maxEngineSize = decimal.Parse(textBoxMaxEngineSizeFilter.Text);
                }
                catch (FormatException)
                {   // An exception is thrown, and a message is displayed if they are empty or in the wrong format
                    MessageBox.Show("Engine size missing or not a number!");
                    checkBoxEngineSize.Checked = false;
                }
            } 

            // Get the list of makes selected
            List<string> selectedMakes = listBoxMakesFilter
                .SelectedItems
                .OfType<string>().ToList();

            // Get the list of years selected
            List<int> selectedYears = listBoxYearsFilter
                .SelectedItems
                .OfType<int>().ToList();

            // Get the list of colors selected
            List<string> selectedColors = listBoxColorsFilter
                .SelectedItems
                .OfType<string>().ToList();

            // Get the list of dealers selected
            List<string> selectedDealers = listBoxDealersFilter
                .SelectedItems
                .OfType<string>().ToList();

            // Filtering based on the selected listbox items
            // AND minimum and maximum price and engine size, if their checkboxes are checked
            var selectedCars = allCars
                .Where(s => selectedMakes.Contains(s.Make) && selectedColors.Contains(s.Color) && selectedDealers.Contains(s.Dealer) && selectedYears.Contains(s.Year)
                && IsMoreThanMinPrice(s.Price, minPrice) && IslessThanMaxPrice(s.Price, maxPrice) && IsMoreThanMinEngineSize(s.EngineSize, minEngineSize) && IslessThanMaxEngineSize(s.EngineSize, maxEngineSize))
                .OrderBy(s => s.Make)
                .ThenBy(s => s.Price);

            // Filling the Data Grid View with the selected cars
            dataGridViewSelectedCars.DataSource = selectedCars.ToList();

            // Formating the car price column to currency
            dataGridViewSelectedCars.Columns[4].DefaultCellStyle.Format = "c";
            
            // Trying to make the columns sortable by clicking on the header. Not working
            for (int i = 0; i < dataGridViewSelectedCars.Columns.Count; i++)
                dataGridViewSelectedCars.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;

            // Creating a list of all cars sorted by Make and by Price
            var everyCar = allCars
                .OrderBy(s => s.Make)
                //.OrderBy(s => s.Color)  // Although the requirements document says it should be ordered by all those,
                //.OrderBy(s => s.Year)   // the resulting list doesn't look like the images in the same document,
                .ThenBy(s => s.Price);    // so I took the liberty to supress these. The same rule was applied to the selected cars list.

            // Filling the Data Grid View with all cars
            dataGridViewAllCars.DataSource = everyCar.ToList();

            // Formating the car price column to currency
            dataGridViewAllCars.Columns[4].DefaultCellStyle.Format = "c";

            // Trying to make the columns sortable by clicking on the header. Not working
            for (int i = 0; i < dataGridViewAllCars.Columns.Count; i++)
                dataGridViewAllCars.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;

            // show statistics for all cars count and average price
            int numberOfCars = everyCar.Count();
            labeAllCarsCount.Text = numberOfCars.ToString();

            // Calculates the average car price of all cars. 
            if (numberOfCars > 0)
            {
                labelAllCarsAveragePrice.Text = everyCar.Average(s => s.Price).ToString("C", CultureInfo.CurrentCulture);
            }
            else // this only avoids an exception if the car list happens to load with error
            {
                labelAllCarsAveragePrice.Text = "0";
            }

            // show statistics for selected cars count and average price
            int numberOfSelectedCars = selectedCars.Count();
            labelSelectedCarsCount.Text = numberOfSelectedCars.ToString();

            // Calculates the average car price of the selected cars. If no car is returned from the filters, the average price is set to 0
            if (numberOfSelectedCars > 0)
            {
                labelSelectedCarsAveragePrice.Text = selectedCars.Average(s => s.Price).ToString("C", CultureInfo.CurrentCulture);
            }
            else
            {
                labelSelectedCarsAveragePrice.Text = "0";
            }
        }

        /// <summary>
        /// Determines if a car price is higher than the minimum price set by the user
        /// </summary>
        /// <param name="price"></param>
        /// <param name="minPrice"></param>
        /// <returns>true if the price is higher than the minimum, OR if the checkbox is not checked</returns>
        public bool IsMoreThanMinPrice(int price, int minPrice)
        {
            return (checkBoxPrice.Checked == true && price >= minPrice) || checkBoxPrice.Checked == false;
        }

        /// <summary>
        /// Determines if a car price is lower than the maximum price set by the user
        /// </summary>
        /// <param name="price"></param>
        /// <param name="maxPrice"></param>
        /// <returns>true if the price is lower than the maximum, OR if the checkbox is not checked</returns>
        public bool IslessThanMaxPrice(int price, int maxPrice)
        {
            return (checkBoxPrice.Checked == true && price <= maxPrice) || checkBoxPrice.Checked == false;
        }

        /// <summary>
        /// Determines if a car engine size is bigger than the minimum engine size set by the user
        /// Always returns true if the checkbox is not checked
        /// </summary>
        /// <param name="engineSize"></param>
        /// <param name="minEngineSize"></param>
        /// <returns>true if the engine size is bigger than the minimum, OR if the checkbox is not checked</returns>
        public bool IsMoreThanMinEngineSize(decimal engineSize, decimal minEngineSize)
        {
            return (checkBoxEngineSize.Checked == true && engineSize >= minEngineSize) || checkBoxEngineSize.Checked == false;
        }

        /// <summary>
        /// Determines if a car engine size is smaller than the maximum engine size set by the user
        /// Always returns true if the checkbox is not checked
        /// </summary>
        /// <param name="engineSize"></param>
        /// <param name="maxEngineSize"></param>
        /// <returns>true if the engine size is smaller than the maximum, OR if the checkbox is not checked</returns>
        public bool IslessThanMaxEngineSize(decimal engineSize, decimal maxEngineSize)
        {
            return (checkBoxEngineSize.Checked == true && engineSize <= maxEngineSize) || checkBoxEngineSize.Checked == false;
        }

        /// <summary>
        /// This sets up the Data Grid Views to a default setting
        /// </summary>
        private void InitializeDataGridViews()
        {
            // Setting up dataGridViewAllCars. 
            dataGridViewAllCars.Columns.Clear();
            dataGridViewAllCars.ReadOnly = true;
            dataGridViewAllCars.AllowUserToAddRows = false;
            dataGridViewAllCars.AllowUserToDeleteRows = false;
            dataGridViewAllCars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewAllCars.RowHeadersVisible = false;
            dataGridViewAllCars.AutoSize = false;

            dataGridViewAllCars.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewAllCars.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // dataGridViewSelectedCars
            dataGridViewSelectedCars.Columns.Clear();
            dataGridViewSelectedCars.ReadOnly = true;
            dataGridViewSelectedCars.AllowUserToAddRows = false;
            dataGridViewSelectedCars.AllowUserToDeleteRows = false;
            dataGridViewSelectedCars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewSelectedCars.RowHeadersVisible = false;
            dataGridViewSelectedCars.AutoSize = false; 

            dataGridViewSelectedCars.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewSelectedCars.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        /// <summary>
        /// This initializes the Listboxes accept more than 1 selection and populates them
        /// </summary>
        private void InitializeListBoxes()
        {
            // setting the listboxes for multiple selections
            listBoxMakesFilter.SelectionMode = SelectionMode.MultiExtended;
            listBoxYearsFilter.SelectionMode = SelectionMode.MultiExtended;
            listBoxColorsFilter.SelectionMode = SelectionMode.MultiExtended;
            listBoxDealersFilter.SelectionMode = SelectionMode.MultiExtended;

            // Reading allCars and adding the Makes list to the filter
            listBoxMakesFilter.DataSource = allCars
                .OrderBy(x => x.Make)
                .Select(x => x.Make)
                .Distinct()
                .ToList();

            // Reading allCars and adding the Years list to the filter
            listBoxYearsFilter.DataSource = allCars
                .OrderBy(x => x.Year)
                .Select(x => x.Year)
                .Distinct()
                .ToList();

            // Reading allCars and adding the Colors list to the filter
            listBoxColorsFilter.DataSource = allCars
                .OrderBy(x => x.Color)
                .Select(x => x.Color)
                .Distinct()
                .ToList();

            // Adding distinct Dealers to the ListBox Dealer
            listBoxDealersFilter.DataSource = allCars
                .OrderBy(x => x.Dealer)
                .Select(x => x.Dealer)
                .Distinct()
                .ToList();
        }
    }
}
