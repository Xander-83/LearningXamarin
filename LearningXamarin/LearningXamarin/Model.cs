﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningXamarin
{
    class Model
    {
        [PrimaryKey, AutoIncrement] //SQLite Attributes required. AutoIncrement increases ID # when new model is enter in the DB
        public int Id { get; set; }
        [MaxLength(250)] //Limit max characters length
        public string NotePad { get; set; }

    }
}