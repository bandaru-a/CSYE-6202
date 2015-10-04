namespace BoxingWeights
{
    public class BoxingWeightClassifier
    {
        public string ClassifyBoxingWeight(int weightInPounds)
        {
            string result = weightInPounds.ToString();
            // your solution/implementation should go in here

            if ((weightInPounds >= 0) && (weightInPounds <= 105))
            {
                result = Constants.Strawweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 105) && (weightInPounds <= 108))
            {
                result = Constants.JuniorFlyweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 108) && (weightInPounds <= 112))
            {
                result = Constants.Flyweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 112) && (weightInPounds <= 115))
            {
                result = Constants.JuniorBantamweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 115) && (weightInPounds <= 118))
            {
                result = Constants.Bantamweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 118) && (weightInPounds <= 122))
            {
                result = Constants.JuniorFeatherweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 122) && (weightInPounds <= 126))
            {
                result = Constants.Featherweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 126) && (weightInPounds <= 130))
            {
                result = Constants.JuniorLightweight + " and " + Constants.Heavyweight;
            }

            else if ((weightInPounds > 130) && (weightInPounds <= 135))
            {
                result = Constants.Lightweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 135) && (weightInPounds <= 140))
            {
                result = Constants.JuniorWelterweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 140) && (weightInPounds <= 147))
            {
                result = Constants.Welterweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 147) && (weightInPounds <= 154))
            {
                result = Constants.JuniorMiddleweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 154) && (weightInPounds <= 160))
            {
                result = Constants.Middleweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 160) && (weightInPounds <= 168))
            {
                result = Constants.SuperMiddleweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 168) && (weightInPounds <= 175))
            {
                result = Constants.LightHeavyweight + " and " + Constants.Heavyweight;

            }
            else if ((weightInPounds > 175) && (weightInPounds <= 200))
            {
                result = Constants.Cruiserweight + " and " + Constants.Heavyweight;

            }
            else
                result = Constants.Heavyweight;

                return result;
            }
        }
    }

            

          

