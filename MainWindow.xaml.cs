/*Keegan Chan
Feb 26 2018
U1CareersKeegan
Show information about the UofT computer science program
*/
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

namespace U1CareersKeegan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPage1_Click(object sender, RoutedEventArgs e)
        {
            txbColumn1.Text = "University: University of Toronto - St. George campus \n Program: Computer Science \n OUAC Program Code: TAD \nUniversity of Toronto is one of the largest and most reputable universities in Canada. In 2017 it boasted 88,766 people attending.";
            txbColumn2.Text = "The St George Campus is in downtown Toronto on the north edge of Chinatown and old Toronto. Toronto has a population of 2,731,571 residents and is the largest city in Canada. The nearby Old Toronto boasts many beautiful old 19th century buildings and Green spaces are spread throughout the whole city.";
            txbColumn3.Text = "Residence information: \n The most popular residence for first years and others who don't stay in colleges for the St. George Campus is The Chestnut residence. Close to city hall, it boasts many cool features such as: selecting your own roommate, weekly cleaning services, and varied styles of 24 / 7 student lounges such as music and fitness rooms.";
            txbColumn4.Text = "Residence fees: \n Doubles cost \n $16,111.22 - $16,311.22 \n Singles cost \n $18,852.22 - $19,052.22";
            BitmapImage bi = new BitmapImage(new Uri("http://www.urbanstrategies.com/wp-content/uploads/2013/11/U-of-T-Character-Areas.jpg"));
            imgComPart.Source = bi;
            imgCover1.Visibility = Visibility.Hidden;
        }

        private void btnPage2_Click(object sender, RoutedEventArgs e)
        {
            txbColumn1.Text = "Prerequisites: \n -ENG4U, Grade 12 English \n -MCV4U, Calculus and Vector \n -Four other grade 12 courses";
            txbColumn2.Text = " -Recommended courses: \n Advanced Functions(MHF4U) \n Mathematics of Data Management(MDM4U) \n Strangely, Computer science(ICS4U) is not written anywhere as required or recommended but is a good idea.";
            txbColumn3.Text = "Low 90 grade averages are required at least to get into the program but most entrants have averages of 95 or more.";
            txbColumn4.Text = "No portfolios or additional requirements needed.";
            BitmapImage bi = new BitmapImage(new Uri("https://bloximages.chicago2.vip.townnews.com/argusobserver.com/content/tncms/assets/v3/editorial/8/b3/8b3ee832-db79-11e7-af09-0bc595ab092f/5a2983a7a83ed.image.jpg"));
            imgComPart.Source = bi;
            imgCover1.Visibility = Visibility.Hidden;
        }

        private void btnPage3_Click(object sender, RoutedEventArgs e)
        {
            txbColumn1.Text = "First year courses: \n \n CSC 108H1 - Introduction to Computer Programming";
            txbColumn2.Text = "CSC 148H1 - Introduction to Computer Science \n \n CSC 165H - Mathematical Expression and Reasoning for Computer Science";
            txbColumn3.Text = " CSC 240H1 - Enriched Introduction to the Theory of Computation \n \n MAT135H1 - Calculus";
            txbColumn4.Text = "To complete a major in computer science you need 8.0 full course equivalents [FCEs], including at least 0.5 FCE at the 400-level in at least three years, 2.5 credits in the first two years and 3 credits in any later years.";
            BitmapImage bi = new BitmapImage(new Uri("https://www.bu.edu/cs/files/2017/03/subject-box-2a.jpg"));
            imgComPart.Source = bi;
            imgCover1.Visibility = Visibility.Hidden;
        }
        private void btnPage4_Click(object sender, RoutedEventArgs e)
        {
            txbColumn1.Text = "Computer programmers are in a fast growing industry with everything becoming digital. Many Computer science graduates find jobs such as software architecture and design, programming, analysis of user requirements, or quality assurance, or if they are more entrepreneurial, running software production or consulting firms";
            txbColumn2.Text = "Graduates from more specialized programs can be found in jobs like computer graphics and animation, game programming, web application development, user-interface design, mathematical and scientific programming, financial modelling, and robotics.";
            txbColumn3.Text = "Some of the more successful or adacemic students could go on to research careers in industrial or government laboratories, or academic careers at the university level.";
            txbColumn4.Text = "UofT even adds additional help in getting some experience before graduates are out in the job market by offering a PEY (Proffesional Experience Year) to help students get some workplace experience to help them get started.";
            BitmapImage bi = new BitmapImage(new Uri("http://career.iresearchnet.com/wp-content/uploads/2014/05/computer-careers-1.jpg"));
            imgComPart.Source = bi;
            imgCover1.Visibility = Visibility.Hidden;
        }
    }
}
