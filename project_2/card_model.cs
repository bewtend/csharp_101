using System.Collections.Generic;

namespace csharp_learning
{
    public class Card
    {
        private string title;
        private string description;
        private string owner;
        private string dimension;
        private string categories;

        public string Title
        {
            get { return title; }
            set
            {

                if (value != null)
                {
                    title = value;
                }
                else
                {
                    title = "Başlıksız";
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != null)
                {
                    description = value;
                }
                else
                {
                    description = "Açıklama yok";
                }
            }
        }

        public string Responsible
        {
            get
            { return owner; }
            set
            { owner = value; }
        }

        public string Dimension
        {
            get { return dimension; }
            set { dimension = value; }
        }

        public string Categories
        {
            get
            {
                if (categories == null) return CategoriesEnums.BOARD.ToString();
                else return categories;
            }
            set
            {
                if (value != null) categories = value;
                else categories = CategoriesEnums.BOARD.ToString();
            }
        }

        public static List<Card> BoardList = new List<Card>()
        {
                new Card()
                {
                    Title = "Örnek 1",
                    Description = "Örnek 1",
                    Responsible = Owner.Test.ToString(),
                    Dimension = Size.XS.ToString(),
                },
                new Card()
                {
                    Title = "Örnek 2",
                    Description = "Örnek 2",
                    Responsible = Owner.Backend.ToString(),
                    Dimension = Size.M.ToString(),
                },
                new Card()
                {
                    Title = "Örnek 3",
                    Description = "Örnek 3",
                    Responsible = Owner.Project_Manager.ToString(),
                    Dimension = Size.XL.ToString(),
                },
        };
    }

    enum Size
    {
        XS = 1,
        S = 2,
        M = 3,
        L = 4,
        XL = 5
    }

    enum Owner
    {
        Test = 1,
        Backend = 2,
        Frontend = 3,
        Project_Manager = 4,
    }

    enum CategoriesEnums
    {
        BOARD,
        TODO,
        INPROGRESS,
        DONE,
    }
}