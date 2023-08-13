using Business;
using DataAccess;
using Entities;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BookManager bookManeger = new BookManager(new EfBookDal());
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        BookRentManager bookRentManager = new BookRentManager(new EfBookRentDal());


        private void Form1_Load(object sender, EventArgs e)
        {
           
            dgrwUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrwBookRent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrwKitapListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrwKitapListesi.DataSource = bookManeger.GetAll();
            dgrwUyeler.DataSource = customerManager.GetAll();
            dgrwBookRent.DataSource = bookRentManager.GetAll();
            dgrwUyeler.Columns["ActiveOrPassive"].Visible = false; // Customers k�sm�nda activeorpassive kolonunu gizle

        }

        public void btnUyeEkle_Click(object sender, EventArgs e)
        {

            try
            {
                string tbxUyeAdText = tbxUyeAd.Text;
                string tbxUyeSoyadText = tbxUyeSoyad.Text;
                string tbxUyeSehirText = tbxUyeSehir.Text;

                if (int.TryParse(tbxUyeAdText, out _) || int.TryParse(tbxUyeSoyadText, out _) || int.TryParse(tbxUyeSehirText, out _))
                {
                    MessageBox.Show("L�tfen t�m de�erleri do�ru girin.");
                    return; // ��lemi durdur
                }

                Customer customer = new Customer();
                customer.CustomerName = tbxUyeAdText;
                customer.CustomerLastName = tbxUyeSoyadText;
                customer.CustomerCity = tbxUyeSehirText;

                // Veritaban�na ekleme i�lemi
                try
                {
                    customerManager.Add(customer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri taban�na eklenemedi!");
                    // customerManager.Add hatas�yla ilgili i�lemler
                }

                // E�er yukar�daki sat�rlarda herhangi bir exception olu�mazsa,
                // yani t�m alanlar string olarak d�zg�nce al�n�yorsa i�leme devam edebilirsiniz.
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata olu�tu");
            }

            dgrwUyeler.DataSource = null;
            dgrwUyeler.DataSource = customerManager.GetAll();
            dgrwUyeler.Columns["ActiveOrPassive"].Visible = false;// Customers k�sm�nda activeorpassive kolonunu gizle

        }

        public void dgrwUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dgrwUyeler_BindingContextChanged(object sender,
    DataGridViewBindingCompleteEventArgs e)
        {

        
        }
        private void btnUyeSil_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow drow in dgrwUyeler.SelectedRows)  //Se�ili Sat�rlar� Silme
            {
                int IdNumber = Convert.ToInt32(drow.Cells[0].Value);
                customerManager.Delete(IdNumber);
            }
            dgrwUyeler.DataSource = null;
            dgrwUyeler.DataSource = customerManager.GetAll();
            dgrwUyeler.Columns["ActiveOrPassive"].Visible = false;
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookName = tbxKitapAdi.Text;
            book.BookAuthor = tbxKitapYazari.Text;
            book.BookLocation = tbxBulunduguKisim.Text;
            
            bookManeger.Add(book);
            dgrwKitapListesi.DataSource = null;
            dgrwKitapListesi.DataSource = bookManeger.GetAll();
       
        }

        private void tbxOduncVer_Click(object sender, EventArgs e)
        {

            int customerId;
            int bookId;

            bookId = Convert.ToInt32(tbxOduncKitapId.Text);
            customerId = Convert.ToInt32(tbxOduncUyeId.Text);
            bookManeger.Delete(bookId); //kitap aktiflik durumu = false, kiralanan kitaplar aktif durumda de�ildir
            dgrwKitapListesi.DataSource=null;
            dgrwKitapListesi.DataSource=bookManeger.GetAll();

            bookRentManager.Add(customerId, bookId); //kiralanan kitaplar k�sm�na se�ili kitab� eklemek
            dgrwBookRent.DataSource = null;
            dgrwBookRent.DataSource = bookRentManager.GetAll();


        }

        private void btnKitab�GeriAl_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dgrwBookRent.SelectedRows)  //Se�ili Sat�rlar� Silme
            {
                int IdNumber = Convert.ToInt32(drow.Cells[4].Value);
                bookRentManager.GetBookBack(IdNumber);
              
            }
            foreach (DataGridViewRow drow in dgrwBookRent.SelectedRows)  //Se�ili Sat�rlar� Silme
            {
                int IdNumber = Convert.ToInt32(drow.Cells[3].Value);
                bookRentManager.Delete(IdNumber);

            }

            dgrwBookRent.DataSource = null;
            dgrwBookRent.DataSource = bookRentManager.GetAll();
            dgrwKitapListesi.DataSource = null;
            dgrwKitapListesi.DataSource = bookManeger.GetAll();

        }
    }
}