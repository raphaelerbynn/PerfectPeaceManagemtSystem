﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public class ClassRoom
    {
        private string name;
        private int capacity;
        private string section;
        private double fees;
        private double tuition;
        private double firstAid;
        private double PTA;
        private double water;
        private double maintenace;
        private double stationary;
        private double cocurricular;

        public ClassRoom() { }

        public ClassRoom(string name, int capacity, string section, double tuition, double firstAid, double PTA, double water, double maintenance, double stationary, double cocurricula, double fees)
        {
            this.name = name;
            this.capacity = capacity;
            this.section = section;
            this.tuition = tuition;
            this.firstAid = firstAid;
            this.PTA = PTA;
            this.water = water;
            this.maintenace = maintenance;
            this.stationary = stationary;
            this.cocurricular = cocurricula;
            this.fees = fees;
        }

        public void insert_class()
        {
            string query = "INSERT INTO Class(name, section, capacity, tuition, firstAid, PTA, water, maintenance, stationary, cocurricular, fees) " +
                "VALUES('" + name + "','" + section + "','" + capacity + "','" + tuition + "','" + firstAid + "','" + PTA + "','" + water + "','" + maintenace + "','" + stationary + "','" + cocurricular + "','" + fees + "')";
            DbClient.query_execute(query);
        }

        public void show_data(DataGridView dataGridView)
        {
            string query = "SELECT class_id, name, section, capacity, fees, teacher_id, CAST(teacher_id AS VARCHAR(50)) AS teacher FROM Class";
            DbClient.dataGridFill(dataGridView, query);
        }

        public int maxCapacity(string name)
        {
            string query = "SELECT capacity FROM Class WHERE name='"+name+"'";
            int capacity = int.Parse(DbClient.query_executeScaler(query));

            return capacity;
        }

        public int curCapacity(string name)
        {
            string query = "SELECT COUNT(*) FROM Student WHERE class='" + name + "'";
            int capacity = int.Parse(DbClient.query_executeScaler(query));

            return capacity;
        }
    }
}
