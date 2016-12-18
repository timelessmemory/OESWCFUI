using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OesUI.Custom;
using OesUI.utils;

namespace OesUI
{
    public delegate void CustomPaginationQuery();

    //pagination class
    public class PaginationUtils
    {
        private const string PERPAGE = "Per Page";
        private const string DOTSTR = "...";
        private const string HINT_FIRST = "hintFirst";
        private const string HINT_LAST = "hintLast";
        private string goStr = "lblGo";
        private string goText = "Go";
        private string goTextBox = "tbPageNum";
        private string pageChooseCB = "cmbPageSize";
        private string TIP_PAGE_INPUT = "inputPageNumber";
        private Font formalFont = new Font(Constants.ARIAL, 9);
        private Color formalColor = Color.FromArgb(94, 94, 94);
        private Color currentPageColor = Color.FromArgb(254, 153, 1);
        private Color color = Color.FromArgb(94, 94, 94);
        private FlowLayoutPanel panel;
        private CustomTipDialog customTipDialog;
        private CustomPaginationQuery custQuery;
        private MyOpaqueLayer myOpaqueLayer;
        private int[] pageSizeCollection;
        private int preBtnWidth = 20;
        private int preBtnHeight = 15;
        private int pageWidth = 20;
        private int pageHeight = 20;
        private int goBtnWidth = 30;
        private int goBtnHeight = 15;
        private int goTextWidth = 35;
        private int goTextHeight = 15;
        private int textMaxLength = 5;
        private int comboxWidth = 50;
        private int comboxHeight = 15;
        private int currentPage = 1;
        private int pageSize = 10;
        private int paddingTop = 6;

        public int TotalRecord { get; set; }

        public int PageSize 
        {
            get 
            {
                return pageSize; 
            }

            set
            {
                pageSize = value;
            }
        }

        public int CurrentPage
        {
            get
            {
                return currentPage;
            }

            set
            {
                this.currentPage = value;
            }
        }

        public int TotalPage 
        {
            get
            {
                if (TotalRecord == 0)
                {
                    return 0;
                }
                else if (TotalRecord % this.pageSize == 0)
                {
                    return TotalRecord / this.pageSize;
                }
                else if (TotalRecord % this.pageSize != 0)
                {
                    return TotalRecord / this.pageSize + 1;
                }
                return 0;
            }
        }

        public PaginationUtils(FlowLayoutPanel panel, CustomTipDialog customTipDialog, int[] pageSizeCollection,
            CustomPaginationQuery custQuery, MyOpaqueLayer myOpaqueLayer)
        {
            this.panel = panel;
            this.customTipDialog = customTipDialog;
            this.pageSizeCollection = pageSizeCollection;
            this.custQuery = custQuery;
            this.myOpaqueLayer = myOpaqueLayer;
            this.customTipDialog.Tag = this.myOpaqueLayer;
        }

        #region
        private Label PreOrNextCommon(Image bgImage)
        {
            Label preOrNextlbl = new Label();
            preOrNextlbl.AutoSize = false;
            preOrNextlbl.Margin = new Padding(0, paddingTop, 5, 0);
            preOrNextlbl.Width = preBtnWidth;
            preOrNextlbl.Height = preBtnHeight;
            preOrNextlbl.Cursor = Cursors.Hand;
            preOrNextlbl.Image = bgImage;
            return preOrNextlbl;
        }

        private void CreatePreBtn(Image bgImage)
        {
            Label preBtn = PreOrNextCommon(bgImage);
            preBtn.Click += new EventHandler(Prep_Click);
            panel.Controls.Add(preBtn);
        }

        private void CreateNextBtn(Image bgImage)
        {
            Label nextBtn = PreOrNextCommon(bgImage);
            nextBtn.Click += new EventHandler(Next_Click);
            panel.Controls.Add(nextBtn);
        }

        private void CreatePage(int text, Font font, Color color)
        {
            Label page = new Label();
            page.AutoSize = true;
            page.Width = pageWidth;
            page.Height = pageHeight;
            page.Text = text.ToString();
            page.Font = font;
            page.Padding = new Padding(0, paddingTop, 0, 0);
            page.ForeColor = color;
            page.Cursor = Cursors.Hand;
            page.Click += new EventHandler(Page_Click);
            panel.Controls.Add(page);
        }

        private void CreateDotPage(string text)
        {
            Label dot = new Label();
            dot.Font = formalFont;
            dot.Padding = new Padding(0, paddingTop, 0, 0);
            dot.TextAlign = ContentAlignment.MiddleCenter;
            dot.ForeColor = Color.FromArgb(94, 94, 94);
            dot.AutoSize = true;
            dot.Width = pageWidth;
            dot.Height = pageHeight;
            dot.Text = text;
            panel.Controls.Add(dot);
        }

        private void CreateGoBtn(TextBox textbox)
        {
            Label go = new Label();
            go.AutoSize = true;
            go.Margin = new Padding(0, paddingTop, 0, 0);
            go.Width = goBtnWidth;
            go.Height = goBtnHeight;
            go.Name = goStr;
            go.Text = goText;
            go.Tag = textbox;
            go.TextAlign = ContentAlignment.MiddleCenter;
            go.Font = formalFont;
            go.ForeColor = Color.White;
            go.BackColor = currentPageColor;
            go.Cursor = Cursors.Hand;
            go.Margin = new Padding(0, 5, 0, 0);
            go.Click += new EventHandler(LblGo_Click);
            panel.Controls.Add(go);
        }

        private TextBox CreateGoPageText()
        {
            TextBox textBox = new TextBox();
            textBox.Name = goTextBox;
            textBox.Width = goTextWidth;
            textBox.Height = goTextHeight;
            textBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textBox.MaxLength = textMaxLength;
            textBox.ForeColor = currentPageColor;
            textBox.BackColor = Color.White;
            textBox.Font = formalFont;
            textBox.KeyDown += new KeyEventHandler(GoText_KeyDown);
            panel.Controls.Add(textBox);
            return textBox;
        }

        private void CreatePageSizeChoose()
        {
            ComboBox combox = new ComboBox();
            combox.Name = pageChooseCB;
            combox.Width = comboxWidth;
            combox.Height = comboxHeight;
            combox.Font = formalFont;
            combox.DropDownStyle = ComboBoxStyle.DropDownList;
            combox.Cursor = Cursors.Hand;
            combox.BackColor = Color.White;
            combox.ForeColor = currentPageColor;
            combox.DataSource = pageSizeCollection;
            panel.Controls.Add(combox);
            combox.SelectedIndex = pageSizeCollection.ToList().IndexOf(PageSize);
            combox.SelectedIndexChanged += CmbPageSize_SelectedIndexChanged;
        }

        public void CustPagination(int curPage, int pageCount)
        {
            //clear last pagination
            panel.Controls.Clear();

            Image preImage = OesUI.Properties.Resources.BTN_PageLeft_20x15_png;
            CreatePreBtn(preImage);

            if (pageCount < 5)
            {
                for (int i = 0; i < pageCount; i++)
                {
                    if ((i + 1) == curPage)
                    {
                        color = currentPageColor;
                    }
                    CreatePage(i + 1, formalFont, color);
                    color = formalColor;
                }
            }
            else
            {
                if (curPage - 3 > 1)
                {
                    CreatePage(1, formalFont, color);
                    CreateDotPage(DOTSTR);

                    for (var i = curPage - 2; i <= curPage; i++)
                    {
                        if (i == curPage)
                        {
                            color = currentPageColor;
                        }
                        CreatePage(i, formalFont, color);
                        color = formalColor;
                    }
                }
                else
                {
                    for (var i = 1; i <= curPage; i++)
                    {
                        if (i == curPage)
                        {
                            color = currentPageColor;
                        }
                        CreatePage(i, formalFont, color);
                        color = formalColor;
                    }
                }

                if (curPage + 3 < pageCount)
                {
                    for (var i = curPage + 1; i <= curPage + 2; i++)
                    {
                        CreatePage(i, formalFont, color);
                    }

                    CreateDotPage(DOTSTR);
                    CreatePage(pageCount, formalFont, color);
                }
                else
                {
                    for (var i = curPage + 1; i <= pageCount; i++)
                    {
                        CreatePage(i, formalFont, color);
                    }
                }
            }

            Image nextImage = OesUI.Properties.Resources.BTN_PageRight_20x15_png;
            CreateNextBtn(nextImage);
            CreatePageSizeChoose();
            CreateDotPage(PERPAGE);

            TextBox textbox = CreateGoPageText();
            CreateGoBtn(textbox);
        }
        #endregion

        private void Prep_Click(object sender, EventArgs e)
        {
            if (CurrentPage == 1)
            {
                customTipDialog.TipMessage = ResourceCulture.GetString(HINT_FIRST);
                myOpaqueLayer.Show();
                myOpaqueLayer.Tag = customTipDialog;
                customTipDialog.Show();
                return;
            }
            else
            {
                CurrentPage -= 1;
                custQuery();
                CustPagination(CurrentPage, TotalPage);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (CurrentPage == TotalPage)
            {
                customTipDialog.TipMessage = ResourceCulture.GetString(HINT_LAST);
                myOpaqueLayer.Show();
                myOpaqueLayer.Tag = customTipDialog;
                customTipDialog.Show();
                return;
            }
            else
            {
                CurrentPage += 1;
                custQuery();
                CustPagination(CurrentPage, TotalPage);
            }
        }

        private void GoText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                GoPageOperation((TextBox)sender);
            }
        }

        private void Page_Click(object sender, EventArgs e)
        {
            CurrentPage = int.Parse(((Label)sender).Text);
            custQuery();
            CustPagination(CurrentPage, TotalPage);
        }

        private void CmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CbPageSize = int.Parse(((ComboBox)sender).Text);
            PageSize = CbPageSize;
            CurrentPage = 1;

            custQuery();
            CustPagination(CurrentPage, TotalPage);
        }

        private void LblGo_Click(object sender, EventArgs e)
        {
            GoPageOperation((TextBox)(((Label)sender).Tag));
        }

        private void GoPageOperation(TextBox textBox)
        {
            if (textBox.Text.Equals(string.Empty))
            {
                customTipDialog.TipMessage = ResourceCulture.GetString(TIP_PAGE_INPUT);
                myOpaqueLayer.Show();
                myOpaqueLayer.Tag = customTipDialog;
                customTipDialog.Show();
                return;
            }

            int goPageNum = 1;
            try
            {
                goPageNum = int.Parse(textBox.Text);
                textBox.Text = string.Empty;
                if (goPageNum <= 0)
                {
                    goPageNum = 1;
                }
                else if (goPageNum > TotalPage)
                {
                    goPageNum = TotalPage;
                }
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }

            CurrentPage = goPageNum;
            custQuery();
            CustPagination(CurrentPage, TotalPage);
        }
    }
}
