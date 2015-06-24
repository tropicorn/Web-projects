using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Xml;

namespace Project_3
{
    public partial class Form1 : Form
    {
        MethodHandler mh = new MethodHandler("http://simon.ist.rit.edu:8080/Services/resources/ESD/");
   

        public string town;
        public string estate;
        public string organization;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] organizations = mh.GetOrgTypes();
            string[] states = mh.GetState();


            cmbOrgTypes.Items.Clear();
            
            //cmbOrgTypes.Items.Insert(0, "--Select an organization--");


            cmbState.Items.Clear();

            foreach (string org in organizations)
            {

                cmbOrgTypes.Items.Add(org);
              

            }

      


            foreach (string state in states)
            {

                cmbState.Items.Add(state);



            }

           

            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //pass in search input text to Form 2
            string name = txtOrgName.Text;

            btnLast f = new btnLast(organization, name, estate, town);
            f.ShowDialog();

            

            
        }

       

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbCity.Items.Clear(); 
            cmbCity.Text = "--Select a town--";

            estate = cmbState.SelectedItem.ToString();

            //find the text in combo box, pass town as parameter in the state
            string[] cities = mh.GetCities(estate);


            foreach (string city in cities)
            {

                    cmbCity.Items.Add(city);

        

            }

          
         
        }


        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

  
            town = cmbCity.SelectedItem.ToString();




        }

        private void cmbOrgTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
                
                

                organization = cmbOrgTypes.SelectedItem.ToString();

                


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}
