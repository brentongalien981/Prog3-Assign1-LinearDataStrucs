using System.Text.RegularExpressions;

namespace Assign1_Question3_Practice
{
    public partial class Form1 : Form
    {
        private List<Athlete> athletes; // All Athletes
        private List<Athlete> currentAthletesList; // Athletes displayed
        private int selectedListItemIndex = -1;



        public Form1()
        {
            InitializeComponent();
            athletes = new List<Athlete>();
            currentAthletesList = athletes;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ReadAthletesData();
        }



        private void ReadAthletesData()
        {
            string csvFilePath = ".\\..\\..\\..\\MyData\\Medals.csv";

            this.athletes = File.ReadAllLines(csvFilePath)
                                       .Skip(1)
                                       .Select(row => this.ReadRowFromCsv(row))
                                       .ToList();

            this.currentAthletesList = this.athletes;

            this.redisplayListViewItems();
        }



        private void redisplayListViewItems()
        {
            ListViewItem[] listViewItems = new ListViewItem[this.currentAthletesList.Count];

            for (int i = 0; i < this.currentAthletesList.Count; i++)
            {
                Athlete a = this.currentAthletesList.ElementAt(i);

                ListViewItem item = new ListViewItem(a.Name);
                item.SubItems.Add(a.OlympicYear.ToString());
                item.SubItems.Add(a.NumOfGold.ToString());
                item.SubItems.Add(a.NumOfSilver.ToString());
                item.SubItems.Add(a.NumOfBronze.ToString());

                listViewItems[i] = item;
            }


            athletesListView.Items.Clear();

            athletesListView.Items.AddRange(listViewItems);
        }



        private Athlete ReadRowFromCsv(string row)
        {
            string[] rowData = row.Split(',');
            Athlete athlete = new Athlete(rowData[0],
                                          Convert.ToInt32(rowData[1]),
                                          Convert.ToInt32(rowData[2]),
                                          Convert.ToInt32(rowData[3]),
                                          Convert.ToInt32(rowData[4]));

            return athlete;
        }



        private void addButton_Click(object sender, EventArgs e)
        {

            // Get the athlete values.
            int olympicYear = String.IsNullOrWhiteSpace(yearTextBox.Text) ? 2022 : Int32.Parse(yearTextBox.Text);
            int numOfGold = String.IsNullOrWhiteSpace(goldTextBox.Text) ? 0 : Int32.Parse(goldTextBox.Text);
            int numOfSilver = String.IsNullOrWhiteSpace(silverTextBox.Text) ? 0 : Int32.Parse(silverTextBox.Text);
            int numOfBronze = String.IsNullOrWhiteSpace(bronzeTextBox.Text) ? 0 : Int32.Parse(bronzeTextBox.Text);

            Athlete newAthlete = new Athlete(nameTextBox.Text, olympicYear, numOfGold, numOfSilver, numOfBronze);

            // Insert new athlete obj to the List.
            this.athletes.Insert(0, newAthlete);
            this.currentAthletesList = this.athletes;


            this.redisplayListViewItems();
        }



        /** 
         * Select a row to be deleted.
         */
        private void athletesListView_Click(object sender, EventArgs e)
        {
            ListViewItem item = athletesListView.SelectedItems[0];
            this.selectedListItemIndex = item.Index;
        }



        /** 
         * NOTE: A row must be selected before deletion.
         */
        private void deleteAthleteButton_Click(object sender, EventArgs e)
        {
            if (this.selectedListItemIndex == -1) { return; }

            Athlete athleteReferenceToBeRemoved = this.currentAthletesList.ElementAt(this.selectedListItemIndex);

            // Remove the referenced athlete from the 2 lists.
            this.currentAthletesList.Remove(athleteReferenceToBeRemoved);
            this.athletes.Remove(athleteReferenceToBeRemoved);

            // Update the ListView.
            athletesListView.Items.RemoveAt(this.selectedListItemIndex);

            // Reset the selected index.
            this.selectedListItemIndex = -1;
        }



        private void searchButton_Click(object sender, EventArgs e)
        {
            // Get search-phrase.
            string searchPhrase = searchTextBox.Text;


            // Set the filtered-athlete-list by using a lambda expression.
            this.currentAthletesList = athletes.FindAll((a) =>
            {
                if (string.IsNullOrEmpty(searchPhrase)) { return true; }

                // Check for name search.
                searchPhrase = searchPhrase.ToLower();
                string athleteName = a.Name.ToLower();
                if (Regex.IsMatch(athleteName, searchPhrase)) { return true; }

                // Check for year search.
                string olympicYear = a.OlympicYear.ToString().ToLower();
                if (Regex.IsMatch(olympicYear, searchPhrase)) { return true; }

                // Check for num of gold search.
                string numOfGold = a.NumOfGold.ToString().ToLower();
                if (Regex.IsMatch(numOfGold, searchPhrase)) { return true; }

                // Check for num of silver search.
                string numOfSilver = a.NumOfSilver.ToString().ToLower();
                if (Regex.IsMatch(numOfSilver, searchPhrase)) { return true; }

                // Check for num of bronze search.
                string numOfBronze = a.NumOfBronze.ToString().ToLower();
                if (Regex.IsMatch(numOfBronze, searchPhrase)) { return true; }

                return false;
            });


            this.redisplayListViewItems();

        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            this.searchTextBox.Text = "";
            this.currentAthletesList = this.athletes;
            this.redisplayListViewItems();
        }
    }
}