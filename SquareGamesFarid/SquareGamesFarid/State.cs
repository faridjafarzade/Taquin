using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SquareGamesFarid
{
    [Table]
    public class State 
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID
        {
            get;
            set;
        }
        [Column]
        public int a
        {
            get;
            set;
        }
        [Column]
        public int b
        {
            get;
            set;
        }
        [Column]
        public int c
        {
            get;
            set;
        }
        [Column]
        public int d
        {
            get;
            set;
        }
        [Column]
        public int e
        {
            get;
            set;
        }
        [Column]
        public int f
        {
            get;
            set;
        }
        [Column]
        public int g
        {
            get;
            set;
        }
        [Column]
        public int h
        {
            get;
            set;
        }
        [Column]
        public int i
        {
            get;
            set;
        }
        [Column]
        public int j
        {
            get;
            set;
        }
        [Column]
        public int k
        {
            get;
            set;
        }
        [Column]
        public int l
        {
            get;
            set;
        }
        [Column]
        public int m
        {
            get;
            set;
        }
        [Column]
        public int n
        {
            get;
            set;
        }
        [Column]
        public int o
        {
            get;
            set;
        }

        [Column]
        public int move
        {
            get;
            set;
        }

        [Column]
        public int space
        {
            get;
            set;
        }
    }
}
