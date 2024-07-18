namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private List<MhsModel> _datasource;
        public Form1()
        {
            InitializeComponent();
            _datasource = new List<MhsModel>()
            {
                new MhsModel("1", "John Doe", new DateTime(1995, 3, 13), "Male"),
                new MhsModel("2", "Jane Doe", new DateTime(1996, 2, 26), "Female"),
                new MhsModel("3", "Bob Smith", new DateTime(1996, 2, 9), "Male"),
                new MhsModel("4", "Sarah Brown", new DateTime(1995, 9, 5), "Female"),
                new MhsModel("5", "Michael Johnson", new DateTime(1995, 7, 20), "Male"),
                new MhsModel("6", "Emily Davis", new DateTime(1996, 4, 25), "Female"),
                new MhsModel("7", "David Wilson", new DateTime(1996, 1, 19), "Male"),
                new MhsModel("8", "Olivia Taylor", new DateTime(1995, 12, 8), "Female"),
                new MhsModel("9", "James Anderson", new DateTime(1995, 8, 15), "Male"),
                new MhsModel("10", "Sophia Martinez", new DateTime(1995, 11, 30), "Female")
            };
            sfDataGrid1.DataSource = _datasource;
        }
    }

    public class MhsModel
    {
        public MhsModel(string id, string name, DateTime dateBirth, string gender)
        {
            Id = id;
            Name = name;
            DateBirth = dateBirth;
            Gender = gender;
        }

        public string Id { get; set; }

        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public string Gender { get; set; }
    }
}
