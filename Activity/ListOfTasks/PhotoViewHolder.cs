﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace App1.Activity.ListOfTasks
{
    public class PhotoViewHolder : RecyclerView.ViewHolder
    {
        //public TextView RatingCardViewImportance { get; private set; }
        public EditText EditName { get; private set; }
        public EditText EditTime { get; private set; }
        public EditText EditNote { get; private set; }
        public RatingBar RatingImportance { get; private set; }
        public CheckBox CheckBoxkReminder { get; private set; }

        public PhotoViewHolder(View itemView) : base(itemView)// ???
        {
            //RatingCardViewImportance = itemView.FindViewById<EditText>(Resource.Id.RatingCardViewImportance);
            EditName = itemView.FindViewById<EditText>(Resource.Id.EditCardViewName);
            EditTime = itemView.FindViewById<EditText>(Resource.Id.EditCardViewTime);
            EditNote = itemView.FindViewById<EditText>(Resource.Id.EditCardViewNote);
            RatingImportance = itemView.FindViewById<RatingBar>(Resource.Id.RatingCardViewImportance);
            CheckBoxkReminder = itemView.FindViewById<CheckBox>(Resource.Id.CheckBoxCardViewReminder);
            #region Запрет на ввод
                EditName.Clickable = false;
                EditName.Focusable = false;
                EditName.LongClickable = false;

                EditTime.Clickable = false;
                EditTime.Focusable = false;
                EditTime.LongClickable = false;

                EditNote.Clickable = false;
                EditNote.Focusable = false;
                EditNote.LongClickable = false;

                RatingImportance.Clickable = false;
                RatingImportance.Focusable = false;
                RatingImportance.LongClickable = false;

                CheckBoxkReminder.Clickable = false;
                CheckBoxkReminder.Focusable = false;
                CheckBoxkReminder.LongClickable = false;
            #endregion

        }
    }
}