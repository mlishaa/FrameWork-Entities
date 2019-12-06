using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TimeTracker.Models;
namespace TimeTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TimeTrackerDBContext context = new TimeTrackerDBContext();
            EmployeeAddTest(context);

            dgEmployees.ItemsSource = (from e in context.Employees
                                       select e).ToList();


        }
        private void EmployeeAddTest(TimeTrackerDBContext context)
        {
            Employee emp = new Employee()
            {
                FirstName = "Bruce",
                lastName = "Waine",
                Gender = true,
                DateOfBirth = DateTime.Parse("3/05/1965"),
                Department = "Sales",
                Role = "Manager",
                HireTime = DateTime.Now.AddYears(-2),
                TimeCards = new List<TimeCard>()
                {
                    new TimeCard()
                    {
                        SubmissionDate = DateTime.Now.AddDays(-7),
                        MondayHours = 8,
                        TuesdayHours=7,
                        WedesdayHours=6,
                        ThursdayHours=8,
                        FridayHours=9,
                        SaturdayHours=6,
                        SundayHours=0
                    }
                }
            };
            context.Employees.Add(emp);
            context.SaveChanges();
            
        }
    }
}
