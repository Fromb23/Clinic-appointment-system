using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicAppointmentSystemFrontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeUI();  // Initialize UI components
        }

        // Method to set up form and UI components
        private void InitializeUI()
        {
            // Form settings
            this.Text = "Clinic Appointment System";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Title Button (reloads form on click)
            Button titleButton = new Button
            {
                Text = "CLINIC APPOINTMENT SYSTEM",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DeepSkyBlue,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                Location = new Point(10, 10),
                Size = new Size(400, 40),
                Cursor = Cursors.Hand  // Hand cursor on hover
            };

            this.Controls.Add(titleButton);

            int formWidth = this.ClientSize.Width;
            int labelWidth = titleButton.Size.Width;
            int x = (formWidth - labelWidth) / 2;
            titleButton.Location = new Point(x, 10);

            titleButton.FlatAppearance.BorderSize = 0;
            titleButton.Click += (sender, e) => ReloadForm();  // Event to reload form
            this.Controls.Add(titleButton);

            // Sidebar Panel
            Panel sidebar = new Panel
            {
                BackColor = Color.LightGray,
                Size = new Size(180, 550),
                Location = new Point(0, 60)
            };
            this.Controls.Add(sidebar);

            // Navigation buttons
            Button btnPatients = CreateButton("Patients", new Point(10, 60));
            btnPatients.Click += (sender, e) => ShowContent("Patients");
            sidebar.Controls.Add(btnPatients);

            Button btnDoctors = CreateButton("Doctors", new Point(10, 120));
            btnDoctors.Click += (sender, e) => ShowContent("Doctors");
            sidebar.Controls.Add(btnDoctors);

            Button btnAppointments = CreateButton("Appointments", new Point(10, 180));
            btnAppointments.Click += (sender, e) => ShowContent("Appointments");
            sidebar.Controls.Add(btnAppointments);

            // Content Panel (Right side for displaying content)
            Panel contentPanel = new Panel
            {
                BackColor = Color.Black,
                Size = new Size(600, 550),
                Location = new Point(180, 60)
            };
            this.Controls.Add(contentPanel);

            // Default description text
            Label description = new Label
            {
                Text = "Welcome to the Clinic Appointment System!\n\n" +
                       "Here you can manage appointments, doctors, and patients.\n\n" +
                       "Click on the buttons on the left to navigate through the system.",
                ForeColor = Color.White,
                Font = new Font("Arial", 14),
                Location = new Point(20, 20),
                Size = new Size(560, 500),
                TextAlign = ContentAlignment.TopLeft
            };
            contentPanel.Controls.Add(description);
        }

        // Method to create a button with hover effect
        private Button CreateButton(string text, Point location)
        {
            Button btn = new Button
            {
                Text = text,
                Size = new Size(160, 40),
                Location = location,
                BackColor = Color.DeepSkyBlue,
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Regular),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand  // Hand cursor on hover
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        // Method to update the content panel based on button click
        private void ShowContent(string contentType)
        {
            Panel contentPanel = (Panel)this.Controls[2];  // Get the content panel
            contentPanel.Controls.Clear();  // Clear previous content

            Label contentLabel = new Label
            {
                Font = new Font("Arial", 14),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                Size = new Size(560, 500)
            };

            // Set content based on selected type
            switch (contentType)
            {
                case "Patients":
                    contentLabel.Text = "List of Patients will go here.\n\n" +
                                        "You can view, add, or manage patients.";
                    break;
                case "Doctors":
                    contentLabel.Text = "List of Doctors will go here.\n\n" +
                                        "You can view, add, or manage doctors.";
                    break;
                case "Appointments":
                    contentLabel.Text = "List of Appointments will go here.\n\n" +
                                        "You can schedule, view, or manage appointments.";
                    break;
            }

            contentPanel.Controls.Add(contentLabel);  // Add content label to the content panel
        }

        // Method to reload the form (reset to default state)
        private void ReloadForm()
        {
            this.Controls.Clear();  // Clear all controls
            InitializeUI();  // Reinitialize the UI components
        }
    }
}