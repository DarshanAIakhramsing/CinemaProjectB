﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class MovieReservationAvailableMoviesItem : UserControl
    {
        public static string chosenMovieForPanel;
        public static string chosenMovieTechnology;
        public static string chosenMovieRuntime;
        public static string chosenMovieDate;
        public static bool chosenMoviePanelBool = false;
        public MovieReservationAvailableMoviesItem()
        {
            InitializeComponent();
        }

        //properties

        private string _movietitle;
        private string _filmtechnology;
        private string _runtime;
        private string _Date;

        [Category("Custom Props")]
        public string MovieTitle
        {
            get { return _movietitle; }
            set { _movietitle = value; Filmtitle.Text = value; }
        }

        [Category("Custom Props")]
        public string FilmTechnology
        {
            get { return _filmtechnology; }
            set { _filmtechnology = value; Filmtechnology.Text = value; }
        }

        [Category("Custom Props")]
        public string Runtime
        {
            get { return _runtime; }
            set { _runtime = value; runtime.Text = value; }
        }

        [Category("Custom Props")]

        public string Date
        {
            get { return _Date; }
            set { _Date = value; date.Text = value; }
        }

        private void Filmtitle_Click(object sender, EventArgs e)
        {
            chosenMovieForPanel = Filmtitle.Text;
            chosenMovieTechnology = Filmtechnology.Text;
            chosenMovieRuntime = runtime.Text;
            chosenMovieDate = date.Text;
            chosenMoviePanelBool = true;
        }

        private void MovieReservationAvailableMoviesItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 0, 0);

            Filmtitle.BackColor = Color.FromArgb(64, 0, 0);

            Filmtechnology.BackColor = Color.FromArgb(64, 0, 0);

            runtime.BackColor = Color.FromArgb(64, 0, 0);

            date.BackColor = Color.FromArgb(64, 0, 0);

        }

        private void MovieReservationAvailableMoviesItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;

            Filmtitle.BackColor = Color.Transparent;

            Filmtechnology.BackColor= Color.Transparent;

            runtime.BackColor = Color.Transparent;

            date.BackColor = Color.Transparent;
        }
    }
}