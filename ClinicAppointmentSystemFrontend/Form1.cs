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
            CustomizeUI();
        }

        // CustomizeUI: Sets up the layout, colors, and controls of the form
        private void CustomizeUI()
        {
            // Set form properties (title, size, start position, background color)

            InitializeTitleLabel();

            InitializeSidebar();

            InitializeContentPanel();

            InitializeFooter();
        }

        // InitializeTitleLabel:
        private void InitializeTitleLabel()
        {
            Label titleLabel = new Label
            {
                Text = "Clinic Appointment System",
                Font = new Font("Arial", 18, FontStyle.Bold),
                ForeColor = Color.DarkSlateBlue,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 60,
                Cursor = Cursors.Hand
            };
            titleLabel.Click += (sender, e) => ReloadDescription(); // Reload the description when clicked
            this.Controls.Add(titleLabel);
        }

        // InitializeSidebar
        private void InitializeSidebar()
        {
            Panel sidebarPanel = new Panel
            {
                BackColor = Color.LightSlateGray,
                Width = 150,
                Dock = DockStyle.Left
            };
            this.Controls.Add(sidebarPanel);

            // Adding buttons for "Add Patient", "Update Patient", "Delete Patient" and "View Patients"
            Button btnAddPatient = CreateSidebarButton("Add Patient", 20);
            Button btnUpdatePatient = CreateSidebarButton("Update Patient", 80);
            Button btnDeletePatient = CreateSidebarButton("Delete Patient", 140);
            Button btnViewPatients = CreateSidebarButton("View Patients", 200);

            // Attach event handlers to buttons
            btnAddPatient.Click += (sender, e) => ShowAddPatientDescription();
            btnUpdatePatient.Click += (sender, e) => ShowUpdatePatientDescription();
            btnDeletePatient.Click += (sender, e) => ShowDeletePatientDescription();
            btnViewPatients.Click += (sender, e) => ShowViewPatientsDescription();

            sidebarPanel.Controls.Add(btnAddPatient);
            sidebarPanel.Controls.Add(btnUpdatePatient);
            sidebarPanel.Controls.Add(btnDeletePatient);
            sidebarPanel.Controls.Add(btnViewPatients);
        }

        // CreateSidebarButton: Helper method to create styled sidebar buttons
        private Button CreateSidebarButton(string text, int top)
        {
            Button button = new Button
            {
                Text = text,
                Size = new Size(120, 40),
                Top = top,
                Width = 130,
                Height = 40,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Regular),
                Cursor = Cursors.Hand
            };
            button.FlatAppearance.BorderSize = 0;
             
            return button;
        }

        // InitializeContentPanel: Configures the main content panel where descriptions are shown
        private void InitializeContentPanel()
        {
            Panel contentPanel = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Padding = new Padding(20) // Ensure margins are sufficient for visibility
            };
            this.Controls.Add(contentPanel);

            Label descriptionLabel = new Label
            {
                Text = "Welcome to the Clinic Appointment System!\n\n" +
                        "This system is designed to help you efficiently manage your clinic's appointments. You can easily schedule, update, and track appointments with patients and doctors.\n\n" +
                        "In addition to managing appointments, you can also view and organize patient information, as well as doctor details, ensuring smooth operations in your clinic.\n\n" +
                         "The system provides an easy-to-use interface for clinic staff, offering full control over managing patient records, doctor schedules, and appointment bookings.",
                Font = new Font("Arial", 12),
                ForeColor = Color.DarkSlateGray,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(15, 10, 10, 10), // Left padding to prevent text clipping

                Cursor = Cursors.IBeam // Cursor change to allow text selection
            };

            descriptionLabel.Padding = new Padding(150, 10, 80, 10);
            descriptionLabel.AutoSize = false;

            contentPanel.Controls.Add(descriptionLabel);
        }

        // InitializeFooter: Adds a footer label at the bottom of the form
        private void InitializeFooter()
        {
            Label footerLabel = new Label
            {
                Text = "© 2024 Clinic Appointment System",
                Font = new Font("Arial", 10, FontStyle.Italic),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Bottom,
                Height = 30,
                Cursor = Cursors.Hand
            };
            this.Controls.Add(footerLabel);
        }

        // Method to show the description for "Add Patient"
        private void ShowAddPatientDescription()
        {
            Panel contentPanel = (Panel)this.Controls[2]; // Get content panel
            contentPanel.Controls.Clear(); // Clear existing content

            Label descriptionLabel = new Label
            {
                Text = "Add Patient details will go here.\n\n" +
                        "You can add a new patient to the system.",
                Font = new Font("Arial", 12),
                ForeColor = Color.DarkSlateGray,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(15, 10, 10, 10),

                Cursor = Cursors.IBeam // Cursor change to allow text selection
            };

            descriptionLabel.Padding = new Padding(150, 10, 80, 10);
            descriptionLabel.AutoSize = false;

            contentPanel.Controls.Add(descriptionLabel);
        }

        // Method to show the description for "Update Patient"
        private void ShowUpdatePatientDescription()
        {
            Panel contentPanel = (Panel)this.Controls[2]; // Get content panel
            contentPanel.Controls.Clear(); // Clear existing content

            Label descriptionLabel = new Label
            {
                Text = "Update Patient details will go here.\n\n" +
                        "You can update an existing patient's information.",
                Font = new Font("Arial", 12),
                ForeColor = Color.DarkSlateGray,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(15, 10, 10, 10),

                Cursor = Cursors.IBeam // Cursor change to allow text selection
            };

            descriptionLabel.Padding = new Padding(150, 10, 80, 10);
            descriptionLabel.AutoSize = false;

            contentPanel.Controls.Add(descriptionLabel);
        }

        // Method to show the description for "Delete Patient"
        private void ShowDeletePatientDescription()
        {
            Panel contentPanel = (Panel)this.Controls[2]; // Get content panel
            contentPanel.Controls.Clear(); // Clear existing content

            Label descriptionLabel = new Label
            {
                Text = "Delete Patient details will go here.\n\n" +
                        "You can delete a patient from the system.",
                Font = new Font("Arial", 12),
                ForeColor = Color.DarkSlateGray,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(15, 10, 10, 10),

                Cursor = Cursors.IBeam // Cursor change to allow text selection
            };

            descriptionLabel.Padding = new Padding(150, 10, 80, 10);
            descriptionLabel.AutoSize = false;

            contentPanel.Controls.Add(descriptionLabel);
        }

        // Method to show the description for "View Patients"
        private void ShowViewPatientsDescription()
        {
            Panel contentPanel = (Panel)this.Controls[2]; // Get content panel
            contentPanel.Controls.Clear(); // Clear existing content

            Label descriptionLabel = new Label
            {
                Text = "List of Patients will go here.\n\n" +
                        "You can view all the patients in the system.",
                Font = new Font("Arial", 12),
                ForeColor = Color.DarkSlateGray,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(15, 10, 10, 10),

                Cursor = Cursors.IBeam // Cursor change to allow text selection
            };

            descriptionLabel.Padding = new Padding(150, 10, 80, 10);
            descriptionLabel.AutoSize = false;

            contentPanel.Controls.Add(descriptionLabel);
        }

        // Method to reload the default description when the title is clicked
        private void ReloadDescription()
        {
            Panel contentPanel = (Panel)this.Controls[2]; // Get content panel
            contentPanel.Controls.Clear(); // Clear existing content

            Label descriptionLabel = new Label
            {
                Text = "Welcome to the Clinic Appointment System!\n\n" +
                        "This system is designed to help you efficiently manage your clinic's appointments. You can easily schedule, update, and track appointments with patients and doctors.\n\n" +
                        "In addition to managing appointments, you can also view and organize patient information, as well as doctor details, ensuring smooth operations in your clinic.\n\n" +
                        "The system provides an easy-to-use interface for clinic staff, offering full control over managing patient records, doctor schedules, and appointment bookings.",
                Font = new Font("Arial", 12),
                ForeColor = Color.DarkSlateGray,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Padding = new Padding(15, 10, 10, 10),

                Cursor = Cursors.IBeam // Cursor change to allow text selection
            };

            descriptionLabel.Padding = new Padding(150, 10, 80, 10);
            descriptionLabel.AutoSize = false;

            contentPanel.Controls.Add(descriptionLabel);
        }
    }
}