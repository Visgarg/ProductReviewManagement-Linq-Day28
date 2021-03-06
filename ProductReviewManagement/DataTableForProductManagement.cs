﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    class DataTableForProductManagement
    {
        DataTable table = new DataTable();
        ProductManagement productManagement = new ProductManagement();
        /// <summary>
        /// Adds the data table for product management 
        /// </summary>
        public void AddDataTable()
        {

            table.Columns.Add("productId");
            table.Columns.Add("userId");
            table.Columns.Add("ratings");
            table.Columns.Add("reviews");
            table.Columns.Add("isLike");
            table.Rows.Add("1", 10, 5, "Good", true);
            table.Rows.Add("2", 3, 4, "Good", true);
            table.Rows.Add("3", 4, 4, "Good", true);
            table.Rows.Add("4", 5, 5, "Good", true);
            table.Rows.Add("5", 4, 3, "Average", true);
            table.Rows.Add("6", 5, 1, "Bad", false);
            table.Rows.Add("7", 10, 5, "Good", true);
            table.Rows.Add("8", 10, 5, "Good", true);
            table.Rows.Add("9", 3, 4, "Good", true);
            table.Rows.Add("10", 10, 2, "Bad", false);
            table.Rows.Add("11", 3, 3, "Average", true);
            table.Rows.Add("12", 10, 3, "Average", false);
        }
        /// <summary>
        /// Calls for retrieving data.
        /// </summary>
        public void CallForRetrievingData()
        {
            //CALLING  retrieving records method from product management
            productManagement.RetrievingRecords(table);
        }
        /// <summary>
        /// Calls for average ratings. UC10
        /// </summary>
        public void CallForAverageRatings()
        {
            productManagement.AverageRatingForUserIDUsingDataTable(table);
        }
        /// <summary>
        /// Calls for review retrieval. UC11
        /// </summary>
        public void CallForReviewRetrieval()
        {
            productManagement.ReviewMessageRetrieval(table);
        }
        /// <summary>
        /// Calls for specific user identifier. UC12
        /// </summary>
        public void CallForSpecificUserId()
        {
            productManagement.SelectRecordsForUserId(table);
        }
        
    }

}
