using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicAppointmentSystemFrontend
{
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            InitializeComponent();
            CustomizeForm();
        }

        // Customize form layout and design
        private void CustomizeForm()
        {
            // Set form properties
            this.Text = "Clinic Appointment System";
            this.Size = new Size(800, 600);
            this.BackColor = Color.White;

            // Header Section
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 100,
                BackColor = Color.LightSkyBlue
            };
            this.Controls.Add(headerPanel);

            Label headerLabel = new Label
            {
                Text = "Clinic Appointment System",
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 30)
            };
            headerPanel.Controls.Add(headerLabel);

            // Footer Section
            Panel footerPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                BackColor = Color.LightGray
            };
            this.Controls.Add(footerPanel);

            Label footerLabel = new Label
            {
                Text = "Contact us: contact@clinic.com | +1234567890",
                Font = new Font("Arial", 10),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(20, 15)
            };
            footerPanel.Controls.Add(footerLabel);

            // Navigation Panel for Buttons
            Panel navigationPanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 150,
                BackColor = Color.LightSteelBlue
            };
            this.Controls.Add(navigationPanel);

            Button btnPatients = CreateButton("Patients", new Point(20, 50));
            btnPatients.Click += (s, e) => ShowPatients();
            navigationPanel.Controls.Add(btnPatients);

            Button btnDoctors = CreateButton("Doctors", new Point(20, 100));
            btnDoctors.Click += (s, e) => ShowDoctors();
            navigationPanel.Controls.Add(btnDoctors);

            Button btnAppointments = CreateButton("Appointments", new Point(20, 150));
            btnAppointments.Click += (s, e) => ShowAppointments();
            navigationPanel.Controls.Add(btnAppointments);

            // Main Content Area (Panel to switch views)
            Panel mainContentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke
            };
            this.Controls.Add(mainContentPanel);
        }

        // Create a button with specific properties
        private Button CreateButton(string text, Point location)
        {
            Button btn = new Button
            {
                Text = text,
                Size = new Size(120, 40),
                Location = location,
                BackColor = Color.DeepSkyBlue,
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Regular),
                FlatStyle = FlatStyle.Flat
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        // Show Patients content
        private void ShowPatients()
        {
            MessageBox.Show("Display Patient Information here.");
        }

        // Show Doctors content
        private void ShowDoctors()
        {
            MessageBox.Show("Display Doctor Information here.");
        }

        // Show Appointments content
        private void ShowAppointments()
        {
            MessageBox.Show("Display Appointment Information here.");
        }
    }
}