﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Helper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            TabSchedule tabSchedule = new TabSchedule();
            panel2.Controls.Add(tabSchedule);
        }

        //Main Menu Buttons
        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            this.Name = "Office-Helper | Schedule";
            panel2.Controls.Clear();
            TabSchedule tabSchedule = new TabSchedule();
            panel2.Controls.Add(tabSchedule);
        }

        private void buttonReminder_Click(object sender, EventArgs e)
        {
            this.Name = "Office-Helper | Reminder";
            panel2.Controls.Clear();
            TabReminder tabReminder = new TabReminder();
            panel2.Controls.Add(tabReminder);
        }

        private void buttonToDo_Click(object sender, EventArgs e)
        {
            this.Name = "Office-Helper | To-Do-List";
            panel2.Controls.Clear();
            TabToDoList tabToDo = new TabToDoList();
            panel2.Controls.Add(tabToDo);
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            this.Name = "Office-Helper | To-Do-List";
            panel2.Controls.Clear();
            TabNotes tabNotes = new TabNotes();
            panel2.Controls.Add(tabNotes);
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            this.Name = "Office-Helper | Calendar";
            panel2.Controls.Clear();
            TabCalendar tabCalendar = new TabCalendar();
            panel2.Controls.Add(tabCalendar);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.panel2.BackColor = Color.Transparent;
        }
    }
}
