
using System;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Xml;

namespace IceDream
{
    public partial class costSetting : Form
    {
        private DateTime clock = DateTime.Now;

        public costSetting()
        {
            InitializeComponent();
            lblClock.Text = clock.ToString();
        }
        //************************************************************************************************
        public static Thread thOpenMM;
        static string textOld;
        XmlDocument xDoc = new XmlDocument();
        string old_tb_iceCream,old_tb_Cups,old_tb_Cone,old_tb_Napkines,old_tb_Spreads,
            old_tb_Sauces, old_tb_Crepes, old_tb_Pancakes, old_tb_Teaspoons,  old_tb_CocaCola, 
            old_tb_Sprite, old_tb_Oranges,old_tb_Nestea, old_tb_Waters, old_tb_Nutellas,
            old_tb_Candies, old_tb_BelgianWaffles,  old_tb_CoffeeBeans, old_tb_InstantCoffees, 
            old_tb_Sugars, old_tb_Mousses, old_tb_WhiteChocolates, old_tb_Strawberries, old_tb_Bananas;
        public static bool infoNoChanged = true;
        //*************************************************************************************************
        private void back_btn_Click(object sender, EventArgs e)          //כפתור חזרה
        {
            if (old_tb_iceCream != tb_iceCream.Text || old_tb_Cups != tb_Cups.Text ||  old_tb_Cone != tb_Cone.Text || old_tb_Napkines != tb_Napkines.Text ||
            old_tb_Spreads != tb_Spreads.Text || old_tb_Sauces != tb_Sauces.Text || old_tb_Crepes != tb_Crepes.Text || old_tb_Pancakes != tb_Pancakes.Text ||
            old_tb_Teaspoons != tb_Teaspoons.Text || old_tb_CocaCola != tb_CocaCola.Text ||  old_tb_Sprite != tb_Sprite.Text || old_tb_Oranges != tb_Oranges.Text ||
            old_tb_Nestea != tb_Nestea.Text ||  old_tb_Waters != tb_Waters.Text || old_tb_Nutellas != tb_Nutellas.Text || old_tb_Candies != tb_Candies.Text ||
            old_tb_BelgianWaffles != tb_BelgianWaffles.Text ||  old_tb_CoffeeBeans != tb_CoffeeBeans.Text ||  old_tb_InstantCoffees != tb_InstantCoffees.Text ||  old_tb_Sugars != tb_Sugars.Text ||
            old_tb_Mousses != tb_Mousses.Text ||  old_tb_WhiteChocolates != tb_WhiteChocolates.Text ||  old_tb_Strawberries != tb_Strawberries.Text ||old_tb_Bananas != tb_Bananas.Text)
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
            else
            {
                this.Close();
                thOpenMM = new Thread(MainMenuForm);
                thOpenMM.SetApartmentState(ApartmentState.STA);
                thOpenMM.Start();
            }
        }
        public void CheckTextChange(TextBox t)                           //שיטה לבדוק אם שונו הערכים בתיבות הטקסט של מחירי המלאי
        {
            if (textOld != t.Text)
            {
                IceDream.MainMenuForm.Changed = true;
            }
        }
        private void costSetting_Load(object sender, EventArgs e)
        {
            IceDream.MainMenuForm.Changed = false;
            textOld = tb_iceCream.Text;
            loadInfo();
        }    //טעינת המסך
        public void loadInfo()
        {
            IceDream.MainMenuForm.saveClicked = false;
            xDoc.Load(IceDream.MainMenuForm.path + "\\DatabaseCost.xml");
            old_tb_iceCream = tb_iceCream.Text = xDoc.SelectSingleNode("allProducts/iceCream/Cost").InnerText;
            old_tb_Cups = tb_Cups.Text = xDoc.SelectSingleNode("allProducts/Cups/Cost").InnerText;
            old_tb_Cone = tb_Cone.Text = xDoc.SelectSingleNode("allProducts/Cones/Cost").InnerText;
            old_tb_Napkines = tb_Napkines.Text = xDoc.SelectSingleNode("allProducts/Napkins/Cost").InnerText;
            old_tb_Spreads = tb_Spreads.Text = xDoc.SelectSingleNode("allProducts/Spreads/Cost").InnerText;
            old_tb_Sauces = tb_Sauces.Text = xDoc.SelectSingleNode("allProducts/Sauces/Cost").InnerText;
            old_tb_Crepes = tb_Crepes.Text = xDoc.SelectSingleNode("allProducts/Crepes/Cost").InnerText;
            old_tb_Pancakes = tb_Pancakes.Text = xDoc.SelectSingleNode("allProducts/Pancakes/Cost").InnerText;
            old_tb_Teaspoons = tb_Teaspoons.Text = xDoc.SelectSingleNode("allProducts/Teaspoons/Cost").InnerText;
            old_tb_CocaCola = tb_CocaCola.Text = xDoc.SelectSingleNode("allProducts/CocaCola/Cost").InnerText;
            old_tb_Sprite = tb_Sprite.Text = xDoc.SelectSingleNode("allProducts/Sprite/Cost").InnerText;
            old_tb_Oranges = tb_Oranges.Text = xDoc.SelectSingleNode("allProducts/Oranges/Cost").InnerText;
            old_tb_Nestea = tb_Nestea.Text = xDoc.SelectSingleNode("allProducts/Nestea/Cost").InnerText;
            old_tb_Waters = tb_Waters.Text = xDoc.SelectSingleNode("allProducts/Waters/Cost").InnerText;
            old_tb_Nutellas = tb_Nutellas.Text = xDoc.SelectSingleNode("allProducts/Nutellas/Cost").InnerText;
            old_tb_Candies = tb_Candies.Text = xDoc.SelectSingleNode("allProducts/Candies/Cost").InnerText;
            old_tb_BelgianWaffles = tb_BelgianWaffles.Text = xDoc.SelectSingleNode("allProducts/BelgianWaffles/Cost").InnerText;
            old_tb_CoffeeBeans = tb_CoffeeBeans.Text = xDoc.SelectSingleNode("allProducts/CoffeeBeans/Cost").InnerText;
            old_tb_InstantCoffees = tb_InstantCoffees.Text = xDoc.SelectSingleNode("allProducts/InstantCoffees/Cost").InnerText;
            old_tb_Sugars = tb_Sugars.Text = xDoc.SelectSingleNode("allProducts/Sugars/Cost").InnerText;
            old_tb_Mousses = tb_Mousses.Text = xDoc.SelectSingleNode("allProducts/Mousses/Cost").InnerText;
            old_tb_WhiteChocolates = tb_WhiteChocolates.Text = xDoc.SelectSingleNode("allProducts/WhiteChocolates/Cost").InnerText;
            old_tb_Strawberries = tb_Strawberries.Text= xDoc.SelectSingleNode("allProducts/Strawberries/Cost").InnerText;
            old_tb_Bananas = tb_Bananas.Text = xDoc.SelectSingleNode("allProducts/Bananas/Cost").InnerText;
        }
        private void updateOldV()
        {
            old_tb_iceCream = tb_iceCream.Text;
            old_tb_Cups = tb_Cups.Text;
            old_tb_Cone = tb_Cone.Text;
            old_tb_Napkines = tb_Napkines.Text;
            old_tb_Spreads = tb_Spreads.Text;
            old_tb_Sauces = tb_Sauces.Text;
            old_tb_Crepes = tb_Crepes.Text;
            old_tb_Pancakes = tb_Pancakes.Text;
            old_tb_Teaspoons = tb_Teaspoons.Text;
            old_tb_CocaCola = tb_CocaCola.Text;
            old_tb_Sprite = tb_Sprite.Text;
            old_tb_Oranges = tb_Oranges.Text;
            old_tb_Nestea = tb_Nestea.Text;
            old_tb_Waters = tb_Waters.Text;
            old_tb_Nutellas = tb_Nutellas.Text;
            old_tb_Candies = tb_Candies.Text;
            old_tb_BelgianWaffles = tb_BelgianWaffles.Text;
            old_tb_CoffeeBeans = tb_CoffeeBeans.Text;
            old_tb_InstantCoffees = tb_InstantCoffees.Text;
            old_tb_Sugars = tb_Sugars.Text;
            old_tb_Mousses = tb_Mousses.Text;
            old_tb_WhiteChocolates = tb_WhiteChocolates.Text;
            old_tb_Strawberries = tb_Strawberries.Text;
            old_tb_Bananas = tb_Bananas.Text;
        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadInfo();
            costSetting.infoNoChanged = true;
        }
        private void save_btn_Click(object sender, EventArgs e)         //כפתור שמור
        {
            IceDream.MainMenuForm.saveClicked = true;
            updateOldV();
            int parsedValue;
            if (!int.TryParse(tb_iceCream.Text, out parsedValue) ||     //בדיקה אם הנתונים שהוזנו חוקיים
                !int.TryParse(tb_Cups.Text, out parsedValue) ||
                !int.TryParse(tb_Cone.Text, out parsedValue) ||
                !int.TryParse(tb_Napkines.Text, out parsedValue) ||
                !int.TryParse(tb_Spreads.Text, out parsedValue) ||
                !int.TryParse(tb_Sauces.Text, out parsedValue) ||
                !int.TryParse(tb_Crepes.Text, out parsedValue) ||
                !int.TryParse(tb_Pancakes.Text, out parsedValue) ||
                !int.TryParse(tb_Teaspoons.Text, out parsedValue) ||
                !int.TryParse(tb_CocaCola.Text, out parsedValue) ||
                !int.TryParse(tb_Sprite.Text, out parsedValue) ||
                !int.TryParse(tb_Oranges.Text, out parsedValue) ||
                !int.TryParse(tb_Nestea.Text, out parsedValue) ||
                !int.TryParse(tb_Waters.Text, out parsedValue) ||
                !int.TryParse(tb_Nutellas.Text, out parsedValue) ||
                !int.TryParse(tb_Candies.Text, out parsedValue) ||
                !int.TryParse(tb_BelgianWaffles.Text, out parsedValue) ||
                !int.TryParse(tb_CoffeeBeans.Text, out parsedValue) ||
                !int.TryParse(tb_InstantCoffees.Text, out parsedValue) ||
                !int.TryParse(tb_Sugars.Text, out parsedValue) ||
                !int.TryParse(tb_Mousses.Text, out parsedValue) ||
                !int.TryParse(tb_WhiteChocolates.Text, out parsedValue) ||
                !int.TryParse(tb_Strawberries.Text, out parsedValue) ||
                !int.TryParse(tb_Bananas.Text, out parsedValue)||
                Int32.Parse(tb_Bananas.Text)<0||Int32.Parse(tb_BelgianWaffles.Text) < 0 ||
                Int32.Parse(tb_Candies.Text) < 0 || Int32.Parse(tb_CocaCola.Text) < 0 ||
                Int32.Parse(tb_CoffeeBeans.Text) < 0 || Int32.Parse(tb_Cone.Text) < 0 ||
                Int32.Parse(tb_Crepes.Text) < 0 || Int32.Parse(tb_Cups.Text) < 0 ||
                Int32.Parse(tb_iceCream.Text) < 0 || Int32.Parse(tb_InstantCoffees.Text) < 0 ||
                Int32.Parse(tb_Mousses.Text) <0 || Int32.Parse(tb_Napkines.Text) < 0 ||
                Int32.Parse(tb_Nestea.Text) < 0 || Int32.Parse(tb_Nutellas.Text) < 0 ||
                Int32.Parse(tb_Oranges.Text) <0 || Int32.Parse(tb_Pancakes.Text) < 0 ||
                Int32.Parse(tb_Sauces.Text) < 0 || Int32.Parse(tb_Spreads.Text) < 0 ||
                Int32.Parse(tb_Sprite.Text) < 0 || Int32.Parse(tb_Strawberries.Text) < 0 ||
                Int32.Parse(tb_Sugars.Text) < 0 || Int32.Parse(tb_Teaspoons.Text) < 0 ||
                Int32.Parse(tb_Waters.Text) < 0 || Int32.Parse(tb_WhiteChocolates.Text) < 0 )
            {
                MessageBox.Show("\t\t,שים לב\n" + ",באחד או יותר מהמוצרים הזנת ערך לא חוקי\n" + "\tיש להזין רק מספרים בין 0-9", "הודעה למשתמש", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #region WriteToXml
            XmlTextWriter xWriterPrice = new XmlTextWriter(IceDream.MainMenuForm.path + "\\DatabaseCost.xml", Encoding.UTF8);
            xWriterPrice.Formatting = Formatting.Indented;
            xWriterPrice.Formatting = Formatting.Indented;
            xWriterPrice.WriteStartElement("allProducts");
            xWriterPrice.WriteStartElement("iceCream");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_iceCream.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Cups");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Cups.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Cones");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Cone.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Napkins");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Napkines.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Spreads");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Spreads.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Sauces");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Sauces.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Crepes");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Crepes.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Pancakes");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Pancakes.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Teaspoons");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Teaspoons.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("CocaCola");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_CocaCola.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Sprite");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Sprite.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Oranges");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Oranges.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Nestea");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Nestea.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Waters");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Waters.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Nutellas");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Nutellas.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Candies");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Candies.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("BelgianWaffles");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_BelgianWaffles.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("CoffeeBeans");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_CoffeeBeans.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("InstantCoffees");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_InstantCoffees.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Sugars");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Sugars.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Mousses");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Mousses.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("WhiteChocolates");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_WhiteChocolates.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Strawberries");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Strawberries.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteEndElement();
            xWriterPrice.WriteStartElement("Bananas");
            xWriterPrice.WriteStartElement("Cost");
            xWriterPrice.WriteString(tb_Bananas.Text);
            xWriterPrice.WriteEndElement();
            xWriterPrice.Close(); 
            #endregion
            Thread.Sleep(1000);
        }
        #region TextChanged
        private void textBox_iceCream_TextChanged(object sender, EventArgs e)
        {
            CheckTextChange(tb_iceCream);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion
        private void timer_Clock_Tick(object sender, EventArgs e)           //טיימר להצגת שעון רץ
        {
            clock = DateTime.Now;
            lblClock.Text = clock.ToString();
        }
        private void MainMenuForm()
        {
            Application.Run(new MainMenuForm());
        }
    }
   
}
