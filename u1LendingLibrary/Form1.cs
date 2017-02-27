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

namespace u1LendingLibrary
{
    public partial class Form1 : Form
    {
        //Global Variables
        List<Friend> friends = new List<Friend>();
        List<Item> items = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            frmFriends f = new frmFriends();
            DialogResult dr = f.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK) 
            {
                //ADD CODE WHEN USER UPDATED FRIENDS
            }
        }

        /// <summary>
        /// Runs when form loads - loads friends and items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            loadFriends();
            loadItems();

        }

        /// <summary>
        /// loadItems - loads the items from a text file and updates
        /// the listbox.
        /// </summary>
        private void loadItems()
        {
            //Streamreader opens a file for reading
            StreamReader sr2 = new StreamReader("items.txt");
            //try - files can cause errors - this prevents them
            try
            {
                //Loop until end of the file
                while (!sr2.EndOfStream)
                {
                    //Read a line
                    string line = sr2.ReadLine();
                    //Split the words on the comma
                    string[] words = line.Split(new char[] { ',' });
                    //Convert the id to an int datatype
                    int tempint;
                    int.TryParse(words[0], out tempint);

                    //add the friend to your file:
                    items.Add(new Item(tempint, words[1]));
                    lbItems.Items.Add(tempint + ": " + words[1]);//adds to listbox
                }
            }
            catch (Exception ex) //catch any errors
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            //close the stream of data from the file.
            sr2.Close();
        }

        private void loadFriends()
        {
            //Streamreader opens a file for reading
            StreamReader sr = new StreamReader("Friends.txt");
            //try - files can cause errors - this prevents them
            try
            {
                //Loop until end of the file
                while (!sr.EndOfStream)
                {
                    //Read a line
                    string line = sr.ReadLine();
                    //Split the words on the comma
                    string[] words = line.Split(new char[] { ',' });
                    //Convert the id to an int datatype
                    int tempint;
                    int.TryParse(words[0], out tempint);

                    //add the friend to your file:
                    friends.Add(new Friend(tempint, words[1], words[2]));
                    lbFriends.Items.Add(tempint + ": " + words[1]);//adds to listbox
                }
            }
            catch (Exception ex) //catch any errors
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            //close the stream of data from the file.
            sr.Close();
        }

    }
}
