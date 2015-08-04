﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WordToTFS.ViewModel.CreateNew
{
    /// <summary>
    ///displays Work items collection and item title for CreateNew view
    /// </summary>
   public class ListBoxItems
   {
       private string title { get; set; }
       public List<string> WorkItems { get; set; }


       private string value;
       private List<string> _listBoxItems;

       public ListBoxItems(string name, List<string> _ListBoxCollection)
        {
            title = name;
            WorkItems = _ListBoxCollection;
           value = _ListBoxCollection[0];

        }

        public string Value
        {
            get { return value; }

            set
            {
                if (null != this.PropertyChanged)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Value"));
                }
                this.value = value;
            }
        }
        public string Title
        {
            get { return title; }

            set
            {
                if (null != this.PropertyChanged)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Title"));
                }
                this.title = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string GetValue()
        {
            return Value;
        }

       public string GetTitle()
       {
           return Title;
       }


   }
}
