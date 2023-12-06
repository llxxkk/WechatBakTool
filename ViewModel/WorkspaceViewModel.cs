﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WechatBakTool.Model;

namespace WechatBakTool.ViewModel
{
    partial class WorkspaceViewModel : ObservableObject
    {
        private WXContact? wXContact = null;
        public WXContact? WXContact {
            get { return wXContact; }
            set {  
                wXContact = value;
                OnPropertyChanged("WXContact");
                OnPropertyChanged("SelectContact");
            }
        }

        public bool SelectContact
        {
            get
            {
                if (WXContact == null)
                    return false;
                else
                    return true;
            }
        }
        [ObservableProperty]
        private ObservableCollection<WXContact>? contacts;

        private string searchString = "";
        public string SearchString
        {
            set
            {
                if (value == "搜索...")
                    searchString = "";
                else
                    searchString = value;

                OnPropertyChanged("SearchString");
            }
            get
            {
                if (searchString == "")
                    return "搜索...";
                return searchString;
            }
        }

        public string SearchRealString
        {
            get
            {
                return searchString;
            }
        }
    }
}