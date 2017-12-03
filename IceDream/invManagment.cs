using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace IceDream
{
    public partial class invManagment : Form
    {
        /***************************************************************************/
        XmlDocument xDoc = new XmlDocument();
        XmlDocument costDoc = new XmlDocument();
        public string pathOutcomes = Path.Combine(Environment.CurrentDirectory, "Outcomes.txt");
        public DateTime dt = new DateTime();                               //הוספת תאריך ביצוע הוצאה מהמלאי
        public static bool btnSaveClick = false;                          //to check if the data were saved 
        public static int sum = 0;                                        //יקבל את סכום ההוצאה הסופי
        private DateTime clock = DateTime.Now;                            //להצגת שעון על המסך
        /***************************************************************************/

        public static Thread thOpenMM;
        public invManagment()
        {
            InitializeComponent();
            lblClock.Text = clock.ToString();
        }
        public void plus(Label a)                                       // שיטת הפלוס
        {
            int i = Int32.Parse(a.Text);
            i++;
            a.Text = i.ToString();
        }
        public void minus(Label a)                                      //שיטת המינוס
        {
            int i = Int32.Parse(a.Text);
            i--;
            if (i >= 0)
                a.Text = i.ToString();
            else
            {
                MessageBox.Show("שים לב, לא ניתן להכניס ערך שלילי", "הודעת אזהרה",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void save_btn_Click(object sender, EventArgs e)         //כפתור שמור 
        {
            summaryInvMang();
            if (sum!=0)
            {
                //****save the account of the products to xml file:  **********************************************************
                #region writeToXml
                XmlTextWriter xWriter = new XmlTextWriter(IceDream.MainMenuForm.path + "\\DatabaseInvManagment.xml", Encoding.UTF8);
                xWriter.Formatting = Formatting.Indented;
                xWriter.WriteStartElement("allProducts");
                xWriter.WriteStartElement("iceCream");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(cream_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Cups");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(cups_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Cones");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(cone_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Napkins");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(napkins_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Spreads");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(spreads_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Sauces");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(sauces_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Crepes");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(crepe_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Pancakes");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(pancake_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Teaspoons");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(teaspoons_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("CocaCola");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(cocaCola_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Sprite");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(sprite_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Oranges");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(oranges_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Nestea");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(nestea_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Waters");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(water_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Nutellas");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(nutella_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Candies");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(candies_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("BelgianWaffles");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(belgianWaffles_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("CoffeeBeans");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(coffeeBeans_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("InstantCoffees");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(instantCoffee_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Sugars");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(sugar_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Mousses");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(mousses_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("WhiteChocolates");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(whiteChocolate_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Strawberries");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(strawberries_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Bananas");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString(banana_lbl.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.Close();
                #endregion  }          
                //*************************************************************************************************************

                //*********write the outcomes to txt file *********************************************************************
                FileStream fileOutcomes = new FileStream(pathOutcomes, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                StreamReader SR = new StreamReader(fileOutcomes);
                string str = "";
                dt = DateTime.Now;
                str = sum.ToString() + " - " + dt;
                SR.Close();
                StreamWriter SW = new StreamWriter(pathOutcomes, true);
                SW.WriteLine(str);
                SW.Close();
                MessageBox.Show("הנתונים נשמרו בהצלחה");
                reset();
                //**************************************************************************************************************
                sum = 0;
            }
            else
            {
                DialogResult dlgresult = MessageBox.Show("לא התבצעו שינויים ", "הודעה לקופאי",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnSaveClick = true;
        }
        private void reset()                                            //שיטה לאיפוס הנתונים
        {
            cream_lbl.Text = "0";
            cups_lbl.Text = "0";
            cone_lbl.Text = "0";
            napkins_lbl.Text = "0";
            spreads_lbl.Text = "0";
            sauces_lbl.Text = "0";
            crepe_lbl.Text = "0";
            pancake_lbl.Text = "0";
            teaspoons_lbl.Text = "0";
            cocaCola_lbl.Text = "0";
            sprite_lbl.Text = "0";
            oranges_lbl.Text = "0";
            nestea_lbl.Text = "0";
            water_lbl.Text = "0";
            nutella_lbl.Text = "0";
            candies_lbl.Text = "0";
            belgianWaffles_lbl.Text = "0";
            coffeeBeans_lbl.Text = "0";
            instantCoffee_lbl.Text = "0";
            sugar_lbl.Text = "0";
            mousses_lbl.Text = "0";
            whiteChocolate_lbl.Text = "0";
            strawberries_lbl.Text = "0";
            banana_lbl.Text = "0";
        }
        #region plus/minus buttons                                             //כפתורי פלוס ומינוס
        private void cream_plus_btn_Click(object sender, EventArgs e)
        {
            plus(cream_lbl);
        }
        private void cream_minus_btn_Click(object sender, EventArgs e)
        {
            minus(cream_lbl);
        }
        private void plus_cups_btn_Click(object sender, EventArgs e)
        {
            plus(cups_lbl);
        }
        private void minus_cups_btn_Click(object sender, EventArgs e)
        {
            minus(cups_lbl);
        }
        private void cone_plus_btn_Click_1(object sender, EventArgs e)
        {
            plus(cone_lbl);
        }
        private void cone_minus_btn_Click_1(object sender, EventArgs e)
        {
            minus(cone_lbl);
        }
        private void napkins_plus_btn_Click(object sender, EventArgs e)
        {
            plus(napkins_lbl);
        }
        private void napkins_minus_btn_Click(object sender, EventArgs e)
        {
            minus(napkins_lbl);
        }
        private void spreads_plus_btn_Click(object sender, EventArgs e)
        {
            plus(spreads_lbl);
        }
        private void spread_minus_btn_Click(object sender, EventArgs e)
        {
            minus(spreads_lbl);
        }
        private void sauces_plus_btn_Click(object sender, EventArgs e)
        {
            plus(sauces_lbl);
        }
        private void sauces_minus_btn_Click(object sender, EventArgs e)
        {
            minus(sauces_lbl);
        }
        private void crepe_plus_btn_Click(object sender, EventArgs e)
        {
            plus(crepe_lbl);
        }
        private void crepe_minus_btn_Click(object sender, EventArgs e)
        {
            minus(crepe_lbl);
        }
        private void pancake_plus_btn_Click(object sender, EventArgs e)
        {
            plus(pancake_lbl);
        }
        private void pancake_minus_btn_Click(object sender, EventArgs e)
        {
            minus(pancake_lbl);
        }
        private void teaspoons_plus_btn_Click(object sender, EventArgs e)
        {
            plus(teaspoons_lbl);
        }
        private void teaspoons_minus_btn_Click(object sender, EventArgs e)
        {
            minus(teaspoons_lbl);
        }
        private void cocaCola_plus_btn_Click(object sender, EventArgs e)
        {
            plus(cocaCola_lbl);
        }
        private void cocaCola_minus_btn_Click(object sender, EventArgs e)
        {
            minus(cocaCola_lbl);
        }
        private void sprite_plus_btn_Click(object sender, EventArgs e)
        {
            plus(sprite_lbl);
        }
        private void sprite_minus_btn_Click(object sender, EventArgs e)
        {
            minus(sprite_lbl);
        }
        private void oranges_plus_btn_Click(object sender, EventArgs e)
        {
            plus(oranges_lbl);
        }
        private void oranges_minus_btn_Click(object sender, EventArgs e)
        {
            minus(oranges_lbl);
        }
        private void nestea_plus_btn_Click(object sender, EventArgs e)
        {
            plus(nestea_lbl);
        }
        private void nestea_minus_btn_Click(object sender, EventArgs e)
        {
            minus(nestea_lbl);
        }
        private void water_plus_btn_Click(object sender, EventArgs e)
        {
            plus(water_lbl);
        }
        private void water_minus_btn_Click(object sender, EventArgs e)
        {
            minus(water_lbl);
        }
        private void nutella_plus_btn_Click(object sender, EventArgs e)
        {
            plus(nutella_lbl);
        }
        private void nutella_minus_btn_Click(object sender, EventArgs e)
        {
            minus(nutella_lbl);
        }
        private void candies_plus_btn_Click(object sender, EventArgs e)
        {
            plus(candies_lbl);
        }
        private void candies_minus_btn_Click(object sender, EventArgs e)
        {
            minus(candies_lbl);
        }
        private void belgianWaffles_plus_btn_Click(object sender, EventArgs e)
        {
            plus(belgianWaffles_lbl);
        }
        private void belgianWaffles_minus_btn_Click(object sender, EventArgs e)
        {
            minus(belgianWaffles_lbl);
        }
        private void coffeeBeans_plus_btn_Click(object sender, EventArgs e)
        {
            plus(coffeeBeans_lbl);
        }
        private void coffeeBeans_minus_btn_Click(object sender, EventArgs e)
        {
            minus(coffeeBeans_lbl);
        }
        private void instantCoffee_plus_btn_Click(object sender, EventArgs e)
        {
            plus(instantCoffee_lbl);
        }
        private void instantCoffee_minus_btn_Click(object sender, EventArgs e)
        {
            minus(instantCoffee_lbl);
        }
        private void sugar_plus_btn_Click(object sender, EventArgs e)
        {
            plus(sugar_lbl);
        }
        private void sugar_minus_btn_Click(object sender, EventArgs e)
        {
            minus(sugar_lbl);
        }
        private void mousse_plus_btn_Click(object sender, EventArgs e)
        {
            plus(mousses_lbl);
        }
        private void whiteChocolate_plus_btn_Click(object sender, EventArgs e)
        {
            plus(whiteChocolate_lbl);
        }
        private void whiteChocolate_minus_btn_Click(object sender, EventArgs e)
        {
            minus(whiteChocolate_lbl);
        }
        private void strawberries_plus_btn_Click(object sender, EventArgs e)
        {
            plus(strawberries_lbl);
        }
        private void strawberries_minus_btn_Click(object sender, EventArgs e)
        {
            minus(strawberries_lbl);
        }
        private void banana_plus_btn_Click(object sender, EventArgs e)
        {
            plus(banana_lbl);
        }
        private void banana_minus_btn_Click(object sender, EventArgs e)
        {
            minus(banana_lbl);

        }

        #endregion                                        
        private void back_btn_Click(object sender, EventArgs e)         // כפתור חזרה

        {
            summaryInvMang();                                         //sum function
             if(sum==0 || btnSaveClick == true)                         //בדיקה אם כבר לחצו "שמור" ואם יש שינוי
            {
                this.Close();
                thOpenMM = new Thread(MainMenuForm);
                thOpenMM.SetApartmentState(ApartmentState.STA);
                thOpenMM.Start();
            }
            else
            {
                DialogResult dlgresult = MessageBox.Show("האם אתה בטוח שברצונך לצאת? הנתונים לא יישמרו", "הודעת אזהרה",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlgresult == DialogResult.OK)
                {
                    this.Close();
                    thOpenMM = new Thread(MainMenuForm);
                    thOpenMM.SetApartmentState(ApartmentState.STA);
                    thOpenMM.Start();
                }
            }
            btnSaveClick = false;
        }    
        public void summaryInvMang()                                    //שיטה לחישוב סך ההוצאה בכל פעם
        {
            sum = 0; //reset the sum
            costDoc.Load(IceDream.MainMenuForm.path + "\\DatabaseCost.xml");
            #region summaryInvManagment                                 //חישוב סכום ההוצאה 

            sum += int.Parse(cream_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/iceCream/Cost").InnerText);
            sum += int.Parse(cups_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Cups/Cost").InnerText);
            sum += int.Parse(cone_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Cones/Cost").InnerText);
            sum += int.Parse(napkins_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Napkins/Cost").InnerText);
            sum += int.Parse(spreads_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Spreads/Cost").InnerText);
            sum += int.Parse(sauces_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Sauces/Cost").InnerText);
            sum += int.Parse(crepe_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Crepes/Cost").InnerText);
            sum += int.Parse(pancake_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Pancakes/Cost").InnerText);
            sum += int.Parse(teaspoons_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Teaspoons/Cost").InnerText);
            sum += int.Parse(cocaCola_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/CocaCola/Cost").InnerText);
            sum += int.Parse(sprite_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Sprite/Cost").InnerText);
            sum += int.Parse(oranges_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Oranges/Cost").InnerText);
            sum += int.Parse(nestea_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Nestea/Cost").InnerText);
            sum += int.Parse(water_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Waters/Cost").InnerText);
            sum += int.Parse(nutella_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Nutellas/Cost").InnerText);
            sum += int.Parse(candies_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Candies/Cost").InnerText);
            sum += int.Parse(belgianWaffles_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/BelgianWaffles/Cost").InnerText);
            sum += int.Parse(coffeeBeans_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/CoffeeBeans/Cost").InnerText);
            sum += int.Parse(instantCoffee_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/InstantCoffees/Cost").InnerText);
            sum += int.Parse(sugar_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Sugars/Cost").InnerText);
            sum += int.Parse(mousses_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Mousses/Cost").InnerText);
            sum += int.Parse(whiteChocolate_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/WhiteChocolates/Cost").InnerText);
            sum += int.Parse(strawberries_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Strawberries/Cost").InnerText);
            sum += int.Parse(banana_lbl.Text) * int.Parse(costDoc.SelectSingleNode("allProducts/Bananas/Cost").InnerText);
            #endregion
       }
        private void MainMenuForm()
          {
            Application.Run(new MainMenuForm());
          }
        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            clock = DateTime.Now;
            lblClock.Text = clock.ToString();
        }   //טיימר להצגת שעון זז
    }
}
