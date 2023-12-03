using System.Collections;
using System.Collections.Generic;

public class PopulationModel
{/**
*Recursive Logistic Growth Model with Overshoot:
*/
    public double CurrentPopulation { get; set; }
    public double GrowthRate { get; set; }
    public double CarryingCapacity { get; set; }
    public double OvershootFactor { get; set; }  // Factor for the overshoot effect

    public PopulationModel(double initialPopulation, double growthRate, double carryingCapacity, double overshootFactor)
    {
        CurrentPopulation = initialPopulation;
        GrowthRate = growthRate;
        CarryingCapacity = carryingCapacity;
        OvershootFactor = overshootFactor;
    }

    public void UpdatePopulation()
    {
        // Standard logistic growth calculation
        double growth = CurrentPopulation * GrowthRate * (1 - CurrentPopulation / CarryingCapacity);
        CurrentPopulation += growth;
        // in case the K carry is exceed, by design it wont as pop value will get closer to zero
        // for game desing purposes Artificial increse in pop can be added.
        CurrentPopulation -= OvershootEffect(CurrentPopulation);
        // Ensure population doesn't fall below zero
        if (CurrentPopulation < 0)
        {
            CurrentPopulation = 0;
        }
    }

    private double OvershootEffect(double currentPopulation)
    {
        double overshoot = currentPopulation - CarryingCapacity;

        if (overshoot > 0)
        {
            //Console.WriteLine("overshoot - > " + overshoot * OvershootFactor);
            return overshoot * OvershootFactor;
        }
        return 0;
    }
}
