using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicAppointmentSystemFrontend
{
    public partial class Form1 : Form
    {
        // Main content panel where we'll display dynamic content
        private Panel mainContentPanel;

        public Form1()
        {
            InitializeComponent();
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            // Set form properties
            this.Text = "CLINIC APPOINTMENT SYSTEM";  // Set the title in CAPS
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

            Button headerButton = new Button
            {
                Text = "CLINIC APPOINTMENT SYSTEM",
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.LightSkyBlue,
                FlatStyle = FlatStyle.Flat,
                AutoSize = true,
                Location = new Point(20, 30)
            };
            headerButton.FlatAppearance.BorderSize = 0;
            headerButton.Click += (s, e) => ResetForm(); // Reset form when clicked
            headerPanel.Controls.Add(headerButton);

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
                Width = 200,
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
            mainContentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White // Set the right panel (dialog box) to white
            };
            this.Controls.Add(mainContentPanel);

            // Default View (Description)
            ShowDefaultView();
        }

        // Create a button with specific properties
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
                FlatStyle = FlatStyle.Flat
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        // Show Default Content
        private void ShowDefaultView()
        {
            ClearMainContentPanel(); // Clear any existing content

            Label descriptionLabel = new Label
            {
                Text = "Welcome to the Clinic Appointment System.\n" +
                       "This system allows you to manage patient appointments, doctor details, and more.\n" +
                       "Use the navigation buttons on the left to manage the operations.",
                Font = new Font("Arial", 14),
                ForeColor = Color.Black,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(20, 50),
                Width = mainContentPanel.Width - 40  // Ensure the text fits within the panel's width
            };

            mainContentPanel.Controls.Add(descriptionLabel);
        }

        // Show Patients content
        private void ShowPatients()
        {
            ClearMainContentPanel(); // Clear current content before displaying new content

            Label patientsLabel = new Label
            {
                Text = "Manage patient information here.",
                Font = new Font("Arial", 14),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(100, 50)
            };
            mainContentPanel.Controls.Add(patientsLabel);
        }

        // Show Doctors content
        private void ShowDoctors()
        {
            ClearMainContentPanel(); // Clear current content before displaying new content
            Label doctorsLabel = new Label
            {
                Text = "Manage doctor details here.",
                Font = new Font("Arial", 14),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(100, 50)
            };
            mainContentPanel.Controls.Add(doctorsLabel);
        }

        // Show Appointments content
        private void ShowAppointments()
        {
            ClearMainContentPanel(); // Clear current content before displaying new content
            Label appointmentsLabel = new Label
            {
                Text = "Schedule and manage appointments for patients.",
                Font = new Font("Arial", 14),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(100, 50)
            };
            mainContentPanel.Controls.Add(appointmentsLabel);
        }

        // Clear the main content panel before displaying new content
        private void ClearMainContentPanel()
        {
            // This method will remove all existing controls from the main content panel
            mainContentPanel.Controls.Clear();
        }

        // Reset the form to its original state when the title button is clicked
        private void ResetForm()
        {
            // Reset the form content
            ShowDefaultView();
        }
    }
}