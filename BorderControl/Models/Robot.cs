﻿using BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    class Robot : IIdentifiable
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
