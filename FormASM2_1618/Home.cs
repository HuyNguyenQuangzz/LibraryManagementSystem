using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormASM2_1618
{
    public partial class Home : Form
    {
        public DataTable dt = new DataTable();
        public DataTable dt1 = new DataTable();
        public Home()
        {
            List<Book> aList = new List<Book>();
            aList.Add(new Book("How to Win Friends and Influence People", "Self-help", "Dale Carnegie", Availability.TRUE, "United States", 1936 ,Status.GOOD));
            aList.Add(new Book("The Alchemist", "Novel", " Paulo Coelho", Availability.TRUE, "Brazilian ", 1988,Status.NEW));
            aList.Add(new Book("Crime and Punishment", "Novel", "Fyodor Dostoevsky", Availability.FALSE, "Russian", 1867,Status.NEW));
            aList.Add(new Book("Being A Happy Teenager", "Self-Help", "Andrew Matthews", Availability.FALSE, "Australia", 1996,Status.OLD));
            aList.Add(new Book("The Great Gatsby ", "Novel", "F. Scott Fitzgerald", Availability.TRUE, "American ", 1925,Status.NEW));
            aList.Add(new Book("Hamlet", "Drama", "William Shakespeare", Availability.TRUE, "England", 1999,Status.OLD));
            aList.Add(new Book("The Lord of the Rings", "Novel", "J. R. R. Tolkien", Availability.TRUE, "England", 1954, Status.NEW));
            aList.Add(new Book("Two children", "Short story", "Thach Lam", Availability.FALSE, "VietNam", 1942, Status.GOOD));
            aList.Add(new Book("Gulliver's Travels", "Children's literature", "Jonathan Swift", Availability.FALSE, "England", 1726, Status.OLD));
            aList.Add(new Book("The Catcher in the Rye", "Novel", "J. D. Salinger", Availability.TRUE, "England", 1945, Status.NEW));
            aList.Add(new Book("To Kill a Mockingbird", "Novel", "Harper Lee", Availability.FALSE, "American", 1960, Status.GOOD));
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));            // ID of Book
            dt.Columns.Add("Title");                      // TiTle of Book
            dt.Columns.Add("Category");                   // Category of Book
            dt.Columns.Add("Author");                     // Author of Book
            dt.Columns.Add("Availability");               // Availablility of Book
            dt.Columns.Add("Publisher");                  // Publisher of Book
            dt.Columns.Add("Year of Publication");        // Year of Publication of Book
            dt.Columns.Add("Status");                     // Status of Book
            foreach (Book each in aList)
            {
                dt.Rows.Add(each.Id, each.Title, each.Category, each.Author, each.Availability, each.Publisher, each.Yearofpublication, each.Status);
            }
            dgvBook.DataSource = dt;
            //3.1 culumn's size
            dgvBook.Columns[0].Width = 80;
            dgvBook.Columns[1].Width = 200;
            dgvBook.Columns[2].Width = 140;
            dgvBook.Columns[3].Width = 120;
            dgvBook.Columns[4].Width = 80;
            dgvBook.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //3.2 change the color
            dgvBook.EnableHeadersVisualStyles = false;
            dgvBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Bisque;
            dgvBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dgvBook.Columns[0].DefaultCellStyle.BackColor = Color.LightPink;
            dgvBook.Columns[0].DefaultCellStyle.ForeColor = Color.Red;
            dgvBook.Columns[1].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            dgvBook.Columns[2].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            dgvBook.Columns[3].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            dgvBook.Columns[4].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            dgvBook.Columns[5].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            dgvBook.Columns[6].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            dgvBook.Columns[7].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            //3.3. Select the whole row instead of a cell
            dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lbCount.Text = dt.Rows.Count.ToString();
            txtId.Text = Book.Count.ToString();
            rbFalse.Checked = true;
            rbTitle.Checked = true;
            // Reader management 
            List<Reader> bList = new List<Reader>();
            bList.Add(new Reader("Nguyen Quang Huy", "Ha Noi", Gender.MALE, "01241232002","12"));
            bList.Add(new Reader("John Nguyen", "New York", Gender.OTHER, "21442152141", "3"));
            bList.Add(new Reader("Nguyen Van Toan", "Ha Noi", Gender.MALE, "51251512", "1"));
            bList.Add(new Reader("Ta Thi Tu", "Ho Chi Minh", Gender.FEMALE, "58768678888", "2"));
            bList.Add(new Reader("Nguyen Van Minh", "Nam Dinh", Gender.MALE, "01241239999", "4"));
            bList.Add(new Reader("Nguyen Van Nam Anh", "Ha Noi", Gender.MALE, "012666666", "5"));
            bList.Add(new Reader("Dao Chi Hoa", "Ha Noi", Gender.FEMALE, "0124885656", "7"));
            bList.Add(new Reader("Bui Thi Huong", "Hai Phong", Gender.FEMALE, "0124777777", "2"));
            bList.Add(new Reader("Duong Thi Na", "Da Nang", Gender.FEMALE, "01243333333", "3"));
            bList.Add(new Reader("Vo Hoai Lam", "Can Tho", Gender.MALE, "0124122222", "5"));

            dt1 = new DataTable();
            dt1.Columns.Add("ID", typeof(int));
            dt1.Columns.Add("Name");
            dt1.Columns.Add("Address");
            dt1.Columns.Add("Gender");
            dt1.Columns.Add("Phone number");
            dt1.Columns.Add("Number of Book Borrowed");
            foreach (Reader each in bList)
            {
                dt1.Rows.Add(each.Idreader, each.Name,each.Address, each.Gender, each.Phone, each.NumberOfBookBorrowed);
            }
            dgvReader.DataSource = dt1;
            rbMale.Checked = true;
            dgvReader.EnableHeadersVisualStyles = false;
            dgvReader.Columns[2].Width = 300;
            dgvReader.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReader.ColumnHeadersDefaultCellStyle.BackColor = Color.Bisque;
            dgvReader.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dgvReader.Columns[0].DefaultCellStyle.BackColor = Color.LightPink;
            dgvReader.Columns[0].DefaultCellStyle.ForeColor = Color.Red;
            lbCount1.Text = dt1.Rows.Count.ToString();
            int i = Reader.Count ;
            txtIdReader.Text = i.ToString();
        }
        // Search Book
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbTitle.Checked)
                dt.DefaultView.RowFilter = "[Title] LIKE '%" + txtSearch.Text + "%'";// like sql
            else if (rbCategory.Checked)
                dt.DefaultView.RowFilter = "[Category] LIKE '%" + txtSearch.Text + "%'";
            else if (rbAuthor.Checked)
                dt.DefaultView.RowFilter = "[Author] LIKE '%" + txtSearch.Text + "%'";
            else
                dt.DefaultView.RowFilter = "[Publisher] LIKE '%" + txtSearch.Text + "%'";
            lbCount.Text = dt.DefaultView.Count.ToString();

        }
        // Delete Book
        private void btnDelete_Click_1(object sender, EventArgs e)
        {            
                if (dgvBook.SelectedRows.Count > 0)
                {
                    var answer = MessageBox.Show(this, "Are you sure to Delete this information of Book?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (answer == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgvBook.SelectedRows[0];
                        int id = int.Parse(row.Cells[0].Value.ToString());
                        DataRow r = dt.Select("[ID] = " + id)[0];
                        dt.Rows.Remove(r);
                    }
                }
                else
                {
                    MessageBox.Show(this, "You must select a row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
        }
        // Add Book
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string str = getValueFromRadioButton();
            Book one = new Book(txtTitle.Text, txtCategory.Text, txtAuthor.Text, str, txtPublisher.Text, int.Parse(txtYear.Text), cbStatus.SelectedItem.ToString());
            if (txtTitle.Text != "" && txtAuthor.Text !=""&& txtCategory.Text !="" && txtYear.Text != "" && txtPublisher.Text!="")
            {
                dt.Rows.Add(one.Id, one.Title, one.Category, one.Author, one.Availability, one.Yearofpublication, one.Publisher, one.Status);
                lbCount.Text = dt.Rows.Count.ToString();
                setToDefault();
            }
            else
                MessageBox.Show("You need to enter all information");
        }
        // get Value From RadioButton
        private string getValueFromRadioButton()
        {
            string str = "";
            if (rbTrue.Checked)
                str = Availability.TRUE;
            else
                str = Availability.FALSE;
            return str;
        }
        // Set to default
        private void setToDefault()
        {
            // Book
            txtId.Text = Book.Count.ToString();
            txtTitle.Text = "";
            txtCategory.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtYear.Text = "";
            cbStatus.SelectedIndex = 0;
            rbFalse.Checked = true;
            // Reader
            int i = Reader.Count;
            txtIdReader.Text = i.ToString();
            txtName.Text = "";
            txtPhone.Text = "";
            rbMale.Checked = true;
            txtAddress.Text = "";
            txtNum.Text = "";
        }
        // Edit Book
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBook.SelectedRows[0];
                if (btnEdit.Text.Equals("Edit"))
                {
                    btnAdd.Visible = false;
                    btnDelete.Visible = false;
                    txtId.Text = row.Cells[0].Value.ToString();
                    txtTitle.Text = row.Cells[1].Value.ToString();
                    txtCategory.Text = row.Cells[2].Value.ToString();
                    txtAuthor.Text = row.Cells[3].Value.ToString();
                    string str = row.Cells[4].Value.ToString();
                    if (str.Equals(Availability.FALSE))
                        rbFalse.Checked = true;
                    else
                        rbTrue.Checked = true;
                    txtPublisher.Text = row.Cells[5].Value.ToString();
                    txtYear.Text =row.Cells[6].Value.ToString();
                    cbStatus.SelectedItem = row.Cells[7].Value.ToString();
                    btnEdit.Text = "Submit";
                    btnCancel.Visible = true;
                    btnEdit.ForeColor = Color.Red;
                    dgvBook.Enabled = false;
                }
                else
                {
                    // Update data
                    btnAdd.Visible = true;
                    btnDelete.Visible = true;
                    string title = txtTitle.Text;
                    string category = txtCategory.Text;
                    string str = getValueFromRadioButton();
                    row.Cells[1].Value = txtTitle.Text;
                    row.Cells[2].Value = txtCategory.Text;
                    row.Cells[3].Value = txtAuthor.Text;
                    row.Cells[4].Value = getValueFromRadioButton();
                    row.Cells[5].Value = txtPublisher.Text;
                    row.Cells[6].Value = txtYear.Text;
                    row.Cells[7].Value = cbStatus.SelectedItem;
                    setToDefault();
                    dgvBook.Enabled = true;
                    btnCancel.Visible = false;
                    btnEdit.Text = "Edit";
                    btnEdit.ForeColor = Color.Black;
                }
            }
            else
            {
                MessageBox.Show(this, "You must select a row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Cancel Book
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEdit.Text = "Edit";
            btnCancel.Visible = false;
            setToDefault();
            dgvBook.Enabled = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
        }
        // Add Reader
        private void btnAdd1_Click(object sender, EventArgs e)
        {          
                string str = getValueFromRadioButtonGender();
                Reader one = new Reader(txtName.Text, txtAddress.Text, str, txtPhone.Text, txtNum.Text);
            if (txtName.Text != "" && txtAddress.Text != "" && txtPhone.Text != "" && txtNum.Text != "") 
            {
                dt1.Rows.Add(one.Idreader, one.Name, one.Address, one.Gender, one.Phone, one.NumberOfBookBorrowed);
                lbCount1.Text = dt1.Rows.Count.ToString();
                setToDefault();
            }
            else
                MessageBox.Show("You need to insert all information");
        }
        private string getValueFromRadioButtonGender()
        {
            string str = "";
            if (rbMale.Checked)
                str = Gender.MALE;
            else if (rbFamale.Checked)
                str = Gender.FEMALE;
            else
                str = Gender.OTHER;
            return str;
        }
        // Edit Reader
        private void btnEdit1_Click(object sender, EventArgs e)
        {
            if (dgvReader.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvReader.SelectedRows[0];
                if (btnEdit1.Text.Equals("Edit"))
                {
                    btnAdd1.Visible = false;
                    btnDelete1.Visible = false;
                    txtIdReader.Text = row.Cells[0].Value.ToString();
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtAddress.Text = row.Cells[2].Value.ToString();
                    string str = row.Cells[3].Value.ToString();
                    if (str.Equals(Gender.MALE))
                        rbMale.Checked = true;
                    else if (str.Equals(Gender.FEMALE))
                        rbFamale.Checked = true;
                    else
                        rbOther.Checked = true;
                    txtPhone.Text = row.Cells[4].Value.ToString();
                    txtNum.Text = row.Cells[5].Value.ToString();
                    btnEdit1.Text = "Submit";
                    btnCancel1.Visible = true;
                    btnEdit1.ForeColor = Color.Red;
                    dgvReader.Enabled = false;
                }
                else
                {
                    btnAdd1.Visible = true;
                    btnDelete1.Visible = true;
                    row.Cells[1].Value = txtName.Text;
                    row.Cells[2].Value = txtAddress.Text;
                    row.Cells[3].Value = getValueFromRadioButtonGender();
                    row.Cells[4].Value = txtPhone.Text;
                    row.Cells[5].Value = txtNum.Text;
                    setToDefault();
                    dgvReader.Enabled = true;
                    btnCancel1.Visible = false;
                    btnEdit1.Text = "Edit";
                    btnEdit1.ForeColor = Color.Black;
                }
            }
            else
            {
                MessageBox.Show(this, "You must select a row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Cancel Reader
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            btnEdit1.Text = "Edit";
            btnCancel1.Visible = false;
            setToDefault();
            dgvReader.Enabled = true;
            btnAdd1.Visible = true;
            btnDelete1.Visible = true;
        }
        // Delete Reader
        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count > 0)
            {
                var answer1 = MessageBox.Show(this, "Are you sure to Delete this information of Book?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (answer1 == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvReader.SelectedRows[0];
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    DataRow r = dt1.Select("[ID] = " + id)[0];
                    dt1.Rows.Remove(r);
                }
            }
            else
            {
                MessageBox.Show(this, "You must select a row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            // Tap for Reader
            //Nothing here
        }

        private void txtSearchReader_TextChanged(object sender, EventArgs e)
        {
            dt1.DefaultView.RowFilter = "[Name] LIKE '%" + txtSearchReader.Text + "%'";  //like SQL
            lbCount.Text = dt1.DefaultView.Count.ToString();
        }
    }
}
