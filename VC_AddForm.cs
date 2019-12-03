using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class VC_AddForm : Form
    {
        public List<Label> Labels = new List<Label>();
        public List<TextBox> textboxes = new List<TextBox>();
        string[] atts;
        int Type;
        int id = 0;
        int post = -1;
        int posd = -1;
    
        string Typeofobj;
        public VC_AddForm()
        {
            InitializeComponent();
        }

        public VC_AddForm(string STypeofobj, string textid)
        {
            this.Typeofobj = STypeofobj;

            //this.id = Int32.Parse(textid);
          
        }
        public void SetDesign(string []Atts,int SType)
        {
            this.Type = SType;
            this.atts = Atts;
            int Y = 40;
            for (int i = 0; i < Atts.Length; i++)
            {
                List<Label> Labels = new List<Label>();
                Label label1 = new Label();
                
                label1.Location = new Point(60, Y);
                label1.Text = Atts[i];
                if( label1.Text == "Birthdate" || label1.Text == "Date")
                {
                    posd = i;
                    Label label2 = new Label();
                    label2.Location = new Point(260, Y);
                    label2.Text = "DD/MM/YY";
                    this.Controls.Add(label2);
                }
                if (label1.Text == "Time")
                {
                    post = i;
                    Label label2 = new Label();
                    label2.Location = new Point(150, Y);
                    label2.Text = "HH:MM:SS";
                    this.Controls.Add(label2);
                }
                label1.AutoSize = true;
              //  label1.Font = new Font("Franklin Gothic",16 , FontStyle.Regular);
                this.Controls.Add(label1);
                Y += 40;
            }
            Y = 40;
                for (int i=0;i<Atts.Length;i++)
                {
                    TextBox TB = new TextBox();
                    TB.Location =new Point (150, Y);
                    this.Controls.Add(TB);
                    textboxes.Add(TB);
                    Y += 40;
                }

            Button TheButt = new Button();
            if(this.Type==1)
                TheButt.Text = "Add";
            else
                TheButt.Text = "Update";
            TheButt.Location = new Point(140, Y);
            this.Controls.Add(TheButt);
            TheButt.Click += TheButt_Click;
        }

        private void TheButt_Click(object sender, EventArgs e)
        {
            string[] ss = new string[textboxes.Count];
            for (int i = 0; i < textboxes.Count; i++)
            {
                if ( posd == i)
                {
                   // if ( textboxes[i].Text != )
                }
                ss[i] = textboxes[i].Text;
            }

            if(Typeofobj=="Kids" && Type ==1)
                AddKid(ss);
            if (Typeofobj == "Kids" && Type == 0)
                EditKid(ss);
            if (Typeofobj == "Utilities" && Type == 1)
                AddUtility(ss);
            if (Typeofobj == "Utilities" && Type == 0)
                EditUtility(ss);
            if (Typeofobj == "Eventss" && Type == 1)
                AddEvent(ss);
            if (Typeofobj == "Eventss" && Type == 0)
                EditEvent(ss);

        }
        

        // KIDS 
        M_Kids SetKidObj(string []values)
        {
            M_Kids NewKid = new M_Kids();
            NewKid.name = values[0];
            NewKid.birthdate = values[1];
            NewKid.gender = values[2];
            NewKid.address = values[3];
            NewKid.parent_email = values[4];
            NewKid.parent_no = Int32.Parse(values[5]);
            return NewKid;
        }
        void AddKid(string []ss)
        {
            M_Kids NewKid = SetKidObj(ss);
            NewKid.ADD("Kids", this.atts, ss);

            M_Attendance AttKid = new M_Attendance();
            string[] xs = new string[4];
            xs[0] = ss[0];
            xs[1] = ss[6];
            xs[2] = "0";
            xs[3] = "0";

            AttKid.AddKidToAttendance(xs);
        }

        void EditKid(string []ss)
        {
            M_Kids NewKid = SetKidObj(ss);
            NewKid.updateuser2("Kids",id, this.atts, ss, "KidID");
        }

        // UTILITIES
        M_Utilities SetUtilityObj(string []values)
        {
            M_Utilities NewUtility = new M_Utilities();
            NewUtility.supplier = values[0];
            NewUtility.type = values[1];
            NewUtility.units = Int32.Parse(values[2]);
            NewUtility.price = Int32.Parse(values[3]);
            return NewUtility;
        }
        void AddUtility(string[] ss)
        {
            M_Utilities NewUtil = SetUtilityObj(ss);
            NewUtil.ADD("Utilities", this.atts, ss);
        }
        void EditUtility(string[] ss)
        {
            M_Utilities NewUtil = SetUtilityObj(ss);
           NewUtil.updateuser2("Utilities",id, this.atts, ss,"UtilityID");
        }

        // Events
        M_Events SetEventObj(string []values)
        {
            M_Events NewEvent = new M_Events();
            NewEvent.Type = values[0];
            NewEvent.Place = values[1];
            NewEvent.Date = values[2];
            NewEvent.Time = values[3];
            NewEvent.price = Int32.Parse(values[4]);
            return NewEvent;
        }
        void AddEvent(string[] ss)
        {
            M_Events NewEvent = SetEventObj(ss);
            NewEvent.ADD("Eventss", this.atts, ss);
        }
        void EditEvent(string[] ss)
        {
            M_Events NewEvent = SetEventObj(ss);
            NewEvent.updateuser2("Eventss", id, this.atts, ss, "EventID");
        }

        private void VC_AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
 