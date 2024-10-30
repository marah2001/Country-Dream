using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
           int counter;

          int randomNumber = Random.Range(1, 21);

        for (counter =0; counter < randomNumber;counter++) 
         {
            
            Debug.Log("Hello, this is number " + randomNumber);
        
             if(randomNumber == 5) { 

                  continue;
                  } 
             

             else if(randomNumber == 15) {  
                
                 break;
                 } 

            //    Debug.Log(randomNumber);
        //   int counter = 0;
        // while (counter >=20)  {
        //     int randomNumber = Random.Range(1, 21);
        //     Debug.Log("Hello, this is number " + randomNumber);
        //     counter++;
            
        //      if(randomNumber == 5)  continue;
        //      else if(randomNumber == 15)  break;
        
        //     Debug.Log(randomNumber);
          
         }
    // Exercise 2
     string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        System.Random random = new System.Random();
        string funnySentence = "";
        int wordsCount = 7;

        int count = 0;
        while (count < wordsCount)
        {
            int index = random.Next(0, words.Length);
            funnySentence += words[index] + " "; 
            count++;
        }

        Debug.Log(funnySentence); 
    }

    
}
