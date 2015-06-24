using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.Net;
using System.IO;
using System.Xml.Serialization;

namespace Project_3
{
    public partial class btnLast : Form
    {

        MethodHandler mh = new MethodHandler("http://simon.ist.rit.edu:8080/Services/resources/ESD/");

        private string uri;

        private string eachState;
        private string eachTown;
        private string eachOrg;
        private string eachName;


        //pagination
        private int CurrentPageIndex = 1;
        private int pgCount = 1;


        public btnLast(string uri)
        {
            this.uri = uri;

        }

        public btnLast(string _organization, string _name, string _state, string _town)
        {
            InitializeComponent();

            eachState = _state;
            eachTown = _town;
            eachOrg = _organization;
            eachName = _name;


        }


        private void Form2_Load(object sender, EventArgs e)
        {

            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/Organizations?type="+eachOrg+ "&name=" +eachName+"&state=" + eachState + "&town=" + eachTown;
            XmlReader xr = mh.getConnection(uri);

            
            int col = 0;
            int rows = 0;

            dataGridView1.Rows.Clear();
            
            while (xr.Read())
            {

                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "row")
                    {
                        rows = dataGridView1.Rows.Add();
                        col = 0;
 
 

                    }

                    else if (xr.NodeType == XmlNodeType.Text)
                    {         
                        
                        dataGridView1.Rows[rows].Cells[col].Value = xr.Value;
                        col++;

                  
                    }






            }




        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {  

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                    //gets org id
                    string cellID = row.Cells["ID"].Value.ToString();
                    //get the tabs names
                    string[] tabs = mh.GetTabs(cellID);


                    string[] general = mh.GetGeneral(cellID);
                    string[] locations = mh.GetLocations(cellID);
                    string[] treatments = mh.GetTreatment(cellID);
                    string[] trainings = mh.GetTraining(cellID);
                    string[] facilities = mh.GetFacilities(cellID);
                    string[] physicians = mh.GetPhysicians(cellID);
                    string[] people = mh.GetPeople(cellID);
                    string[] equipments = mh.GetEquipment(cellID);

                    

                    


                        // Add Tab control
                        TabControl tbControl1 = new TabControl();
                        tbControl1.Size = new System.Drawing.Size(700, 250);
                        tbControl1.Location = new System.Drawing.Point(48, 248);
                        tbControl1.TabIndex = 1;
                        tbControl1.Name = "tbControl";
                        tbControl1.SelectedIndex = 0;
      
                        
                        //loop through names for tabs, add tabs to contol
                        foreach (string tab in tabs)
                        {
                            TextBox txOutput = new TextBox();
                            txOutput.Multiline = true;
                            txOutput.Dock = DockStyle.Fill;
                            txOutput.Name = tab;
                            //add scroll bar to textbox
                            txOutput.ScrollBars = ScrollBars.Vertical;

                            SplitContainer sc = new SplitContainer();
                            sc.Dock = DockStyle.Fill;
                            

                            TabPage tbPage = new TabPage(tab);
                            tbPage.Size = new System.Drawing.Size(610, 250);
                            tbPage.UseVisualStyleBackColor = true;
                            tbPage.Name = tab;


                            WebBrowser web = new WebBrowser();
                            web.Dock = DockStyle.Fill;
                            web.ScrollBarsEnabled = true;


                            if (tbPage.Text == "General")
                            {
                                

                                //NEED if statement to check tab text
                                foreach (string org in general)
                                {
                                    
                                    txOutput.Text += org + "\r\n";
                                    

                                }

                           }



                           else if (tbPage.Text == "Locations")
                           {
                              

                               foreach (string loc in locations)
                                {
                                    if (loc.Equals("main") || loc.Equals("mailing") || loc.Equals("branch"))
                                    {

                                        string street = locations[2].ToString();
                                        string city = locations[4].ToString();
                                        string state = locations[5].ToString();
                                        string zip = locations[6].ToString();
                                        string longitude = locations[11].ToString();
                                        string latitude = locations[10].ToString();

                                            //add split container to textbox
                                            txOutput.Text += "Type: " + loc + "\r\nAddress:" + street +
                                                "\r\nCity:" + city + "\r\nState:" + locations[5].ToString()
                                                + "\r\nZip:" + zip + "\r\nCounty:" + locations[13].ToString()
                                                + "\r\nPhone:" + locations[7].ToString() + "\r\nTTY:" + locations[8].ToString()
                                                + "\r\nLatitude:" + latitude + "\r\nLongitude:" + longitude + "\r\n\r\n";

                                           
                                            sc.Panel1.Controls.Add(txOutput);
                                           

                                                try
                                                {
                                                    StringBuilder queryAddress = new StringBuilder();
                                                    queryAddress.Append("http://maps.google.com/maps?q=");
                                                    

                                                    if (street != null)
                                                    {

                                                        queryAddress.Append(street + "," + "+");
                                                    }

                                                    if (city != null)
                                                    {

                                                        queryAddress.Append(city + "," + "+");
                                                    }

                                                    if (state != null)
                                                    {

                                                        queryAddress.Append(state + "," + "+");
                                                    }

                                                    if (zip != null)
                                                    {

                                                        queryAddress.Append(zip + "," + "+");
                                                    }

                                                    //go to google maps on a browser
                                                    web.Navigate(queryAddress.ToString());
                                                    sc.Panel2.Controls.Add(web);

                                                   
                                                }

                                                catch (Exception)
                                                {


                                                }
                                            
                                    }


                                    }

                                    
                            }

                            else if (tbPage.Text == "Treatment")
                            {


                                foreach (string treat in treatments)
                                {
 
                                        txOutput.Text += treat + "\r\n";

                                }

                            }

                            else if (tbPage.Text == "Training")
                            {


                                foreach (string train in trainings)
                                {

                                    txOutput.Text += train + "\r\n";



                                }

                            }

                            else if (tbPage.Text == "Facilities")
                            {


                                foreach (string fac in facilities)
                                {

                                    txOutput.Text += fac + "\r\n";



                                }

                            }

                            else if (tbPage.Text == "Physicians")
                            {


                                foreach (string phys in physicians)
                                {

                                    txOutput.Text += phys;



                                }

                            }

                            else if (tbPage.Text == "Equipment")
                            {


                                foreach (string equip in equipments)
                                {

                                    txOutput.Text += equip + "\r\n";



                                }

                            }

                            else if (tbPage.Text == "People")
                            {


                                foreach (string peo in people)
                                {

                                    txOutput.Text += peo + "\r\n";



                                }

                            }


                            //tbPage.Controls.Add(lbl);
                            if (tbPage.Text != "Locations")
                            {
                                

                                tbPage.Controls.Add(txOutput);
                            }

                            tbPage.Controls.Add(sc);
                            tbControl1.TabPages.Add(tbPage);

                            //MessageBox.Show("text added");
                            



                        }


                        //remove tab pages of previous Control
                        for (int i = 0; i < Controls.Count; i++)
                        {
                            if (Controls[i].Name.Equals("tbControl"))
                            {
                                Controls.RemoveAt(i);
                                break;
                            }

                        }

                        Controls.Add(tbControl1);
                       
                    }
                

        }

        

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnPrev_Click(object sender, EventArgs e)
        {
            int pageStartIndex = 1;

            if (this.pgCount > 5 && CurrentPageIndex > 2)
                pageStartIndex = CurrentPageIndex - 2;

            if (CurrentPageIndex < 1)
            {
                CurrentPageIndex = 1;
            }
            else if (CurrentPageIndex > pgCount)
            {
                CurrentPageIndex = pgCount;
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex++;

            if (this.CurrentPageIndex > (this.pgCount - 1))
                this.CurrentPageIndex = this.pgCount - 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = this.pgCount - 1;
        }



    }
}
