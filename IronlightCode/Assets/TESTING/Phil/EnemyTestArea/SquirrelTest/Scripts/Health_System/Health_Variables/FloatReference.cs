﻿// ----------------------------------------------------------------------------
// Capstone 2020 - IronLight
// 
// Programmer: Phil James
// Date:   01/23/2020
//
// Description : This Sript will auto link to the UnitHealth script , all the declare variables on this script will reflect in the Inspector UnitHealth Script
//
// ----------------------------------------------------------------------------
using System;

[Serializable]
public class FloatReference
{
    public bool UseConstant = true;                                         //by Default was set into True , you must assign value here Only if you dont wanna use Pluggable Variables
    public float ConstantValue;
    public FloatVariable Variable;                                          //if you use Pluggable Variable, Turn off / uncheck the boolean UseConstant.

    public FloatReference()
    { }

    public FloatReference(float value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    public float Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
    }

    public static implicit operator float(FloatReference reference)
    {
        return reference.Value;
    }
}










































































































































































































































































































































































































































































































// Programmer: Phil James
// Date:   01/23/2020
// LinkedIn: https://www.linkedin.com/in/phillapuz/