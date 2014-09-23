using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Battery
{
    // fields
    private string description;
    private string lifeInHours;

    // properties
    public string Description
    {
        get
        {
            return this.description;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NullReferenceException("String value can not be null or empty.");
            }
            this.description = value;
        }
    }

    public string LifeInHours
    {
        get
        {
            return this.lifeInHours;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException("Value can not be negative");
            }
            this.lifeInHours = value;
        }
    }

    // constructors
    public Battery()
    { }

    public Battery(string description)
    {
        this.Description = description;
    }

    public Battery(string description, string lifeInHours)
        : this(description)
    {
        this.LifeInHours = lifeInHours;
    }

    // console output
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        
        if(this.Description != null)
        {
            result.AppendLine(this.Description);
        }

        if(this.LifeInHours != null)
        {
            result.AppendLine(this.LifeInHours + " hours");
        }
        return result.ToString();
    }
}