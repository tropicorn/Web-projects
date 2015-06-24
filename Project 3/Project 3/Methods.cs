using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Xml;
using System.Windows.Forms;


namespace Project_3
{
    public class MethodHandler
    {
        private string uri;


        public MethodHandler(string uri)
        {
            this.uri = uri;
        }


        #region Get organizations

        public string[] GetOrgTypes()
        {


            string uri = this.uri + "OrgTypes";
                
            List<string> orgList = new List<string>();
            XmlReader xr = getConnection(uri);


            while (xr.Read())
            {
                if (xr.Value != "")
                {

                    xr.ReadToFollowing("type");
                    orgList.Add(xr.ReadElementContentAsString());

                }
            }

            return orgList.ToArray();

        }



        #endregion

        public string[] GetState()
        {

            string uri = this.uri+ "States";

            List<string> stateList = new List<string>();
            XmlReader xr = getConnection(uri);


            while (xr.Read())
            {
                if (xr.Value != "")
                {

                    stateList.Add(xr.Value);

                }
            }

            return stateList.ToArray();

        }



        //get the cities for each state
        public string[] GetCities(string state)
        {

            string uri = this.uri + "Cities?state="+state;

            List<string> cityList = new List<string>();
            XmlReader xr = getConnection(uri);


            while (xr.Read())
            {
                if (xr.Value != "")
                {

                    cityList.Add(xr.Value);

                }
            }

            return cityList.ToArray();

        }




        //get individual org based on ID
        public string[] GetTabs(string orgID)
        {

            string uri = this.uri + "Application/Tabs?orgId="+orgID;

            List<string> tabList = new List<string>();
            XmlReader xr = getConnection(uri);


            while (xr.Read())
            {
                if (xr.Value != "")
                {

                    tabList.Add(xr.Value);

                }
            }

            return tabList.ToArray();

        }

        //get general info
        public string[] GetGeneral(string orgID)
        {

            string uri = this.uri + orgID+"/General";

            List<string> orgList = new List<string>();
            XmlReader xr = getConnection(uri);


            while (xr.Read())
            {
                if (xr.Value != "")
                {

                    orgList.Add(xr.Value);

                }
            }

            return orgList.ToArray();

        }

        //get locations
        public string[] GetLocations(string orgID)
        {

            string uri = this.uri + orgID + "/Locations";

            List<string> locList = new List<string>();
            XmlReader xr = getConnection(uri);


            while (xr.Read())
            {
                if (xr.Value != "")
                {

                    locList.Add(xr.Value);

                }
            }

            return locList.ToArray();

        }

        //get treatments
        public string[] GetTreatment(string orgID)
        {

            string uri = this.uri + orgID + "/Treatments";

            List<string> treatList = new List<string>();
            XmlReader xr = getConnection(uri);


            while (xr.Read())
            {
                if (xr.Value != "")
                {
                    while (xr.ReadToFollowing("treatment"))
                    {
                        try
                        {
                            xr.ReadToFollowing("type");
                            treatList.Add("Type: " + xr.ReadElementContentAsString());

                            xr.ReadToFollowing("abbreviation");
                            treatList.Add("Abbreviation: " + xr.ReadElementContentAsString() + "\r\n");
                        }
                        catch (Exception)
                        {

                        }
                    }



                }


            }
            

            return treatList.ToArray();

        }

        //get Training
        public string[] GetTraining(string orgID)
        {

            string uri = this.uri + orgID + "/Training";

            List<string> trainList = new List<string>();
            XmlReader xr = getConnection(uri);


            while (xr.Read())
            {
                if (xr.Value != "")
                {
                    while (xr.ReadToFollowing("training"))
                    {
                        try
                        {
                            xr.ReadToFollowing("type");
                            trainList.Add("Type: " + xr.ReadElementContentAsString());

                            xr.ReadToFollowing("abbreviation");
                            trainList.Add("Abbreviation: " + xr.ReadElementContentAsString() + "\r\n");
                        }
                        catch (Exception)
                        {

                        }
                    }



                }


            }

            return trainList.ToArray();

        }

        //get Facilities
        public string[] GetFacilities(string orgID)
        {

            string uri = this.uri + orgID + "/Facilities";

            List<string> faciList = new List<string>();
            XmlReader xr = getConnection(uri);


            while (xr.Read())
            {
                if (xr.Value != "")
                {
                    while (xr.ReadToFollowing("facility"))
                    {
                        try
                        {
                            xr.ReadToFollowing("type");
                            faciList.Add("Type: " + xr.ReadElementContentAsString());

                            xr.ReadToFollowing("quantity");
                            faciList.Add("Quantity: " + xr.ReadElementContentAsString() + "\r\n");

                            xr.ReadToFollowing("description");
                            faciList.Add("Description: " + xr.ReadElementContentAsString() + "\r\n");

                        }
                        catch (Exception)
                        {

                        }
                    }



                }
            }

            return faciList.ToArray();

        }

        //get Physicians
        public string[] GetPhysicians(string orgID)
        {

            string uri = this.uri + orgID + "/Physicians";

            List<string> physList = new List<string>();
            XmlReader xr = getConnection(uri);


            while (xr.Read())
            {
                if (xr.Value != "")
                {
                    while (xr.ReadToFollowing("physician"))
                    {
                        try
                        {
                            xr.ReadToFollowing("fName");
                            physList.Add("Name: " + xr.ReadElementContentAsString());

                            xr.ReadToFollowing("mName");
                            physList.Add(" "+ xr.ReadElementContentAsString());

                            xr.ReadToFollowing("lName");
                            physList.Add(" "+ xr.ReadElementContentAsString() + "\r\n");

                            xr.ReadToFollowing("license");
                            physList.Add("  License: " +xr.ReadElementContentAsString() + "\r\n");

                            xr.ReadToFollowing("phone");
                            physList.Add("  Contact Info: " + xr.ReadElementContentAsString() + "\r\n\r\n");



                        }
                        catch (Exception)
                        {

                        }
                    }



                }
            }

            return physList.ToArray();

        }


        //get People
        public string[] GetPeople(string orgID)
        {

            string uri = this.uri + orgID + "/People";

            List<string> peoList = new List<string>();
            XmlReader xr = getConnection(uri);

            while (xr.Read())
            {
                if (xr.Value != "")
                {

                    

                    while (xr.ReadToFollowing("person"))
                    {
                        try
                        {

                            xr.ReadToFollowing("personCount");
     
                            string pCount = xr.ReadContentAsString();

                            if (pCount != "0")
                            {

                                xr.ReadToFollowing("honorific");
                                peoList.Add("Name: " + xr.ReadElementContentAsString());

                                xr.ReadToFollowing("fName");
                                peoList.Add(" " + xr.ReadElementContentAsString());

                                xr.ReadToFollowing("mName");
                                peoList.Add(" " + xr.ReadElementContentAsString());

                                xr.ReadToFollowing("lName");
                                peoList.Add(" " + xr.ReadElementContentAsString());

                                xr.ReadToFollowing("suffix");
                                peoList.Add(" " + xr.ReadElementContentAsString() + "\r\n");

                                xr.ReadToFollowing("role");
                                peoList.Add("   Role: " + xr.ReadElementContentAsString() + "\r\n\r\n");
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }



                }
                else
                {
                    peoList.Add("No People found");
                }
            }

            return peoList.ToArray();

        }

        //get Equipment
        public string[] GetEquipment(string orgID)
        {

            string uri = this.uri + orgID + "/Equipment";

            List<string> equipList = new List<string>();
            XmlReader xr = getConnection(uri);



            while (xr.Read())
            {
                if (xr.Value != "")
                {
                    while (xr.ReadToFollowing("equipment"))
                    {
                        try
                        {
                            xr.ReadToFollowing("type");
                            equipList.Add("Type: " + xr.ReadElementContentAsString());

                            xr.ReadToFollowing("quantity");
                            equipList.Add("Quantity: " + xr.ReadElementContentAsString() + "\r\n");

                            xr.ReadToFollowing("description");
                            equipList.Add("Description: " + xr.ReadElementContentAsString() + "\r\n");
                            
                        }
                        catch (Exception)
                        {

                        }
                    }



                }


            }

            return equipList.ToArray();

        }



        public XmlReader getConnection(string uri)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
            req.Method = "GET"; //get method request on the above web request
            req.Accept = "application/xml";
            req.MediaType = "application/xml";

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            Stream str = res.GetResponseStream(); //converts the response into a usable stream
            XmlReader x = XmlReader.Create(str); //reads the stream as an XML object with the settings

            return x;
        }




    }
}
