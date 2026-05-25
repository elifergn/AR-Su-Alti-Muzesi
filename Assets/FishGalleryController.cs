using UnityEngine;

public class FishGalleryController : MonoBehaviour
{
    public GameObject[] fishGroups;

    private int currentFish = 0;

    void Start()
    {
        ShowFish(currentFish);
    }

    public void NextFish()
    {
        currentFish++;

        if (currentFish >= fishGroups.Length)
        {
            currentFish = 0;
        }

        ShowFish(currentFish);
    }

    public void PreviousFish()
    {
        currentFish--;

        if (currentFish < 0)
        {
            currentFish = fishGroups.Length - 1;
        }

        ShowFish(currentFish);
    }

    void ShowFish(int index)
    {
        for (int i = 0; i < fishGroups.Length; i++)
        {
            fishGroups[i].SetActive(false);
        }

        fishGroups[index].SetActive(true);
    }
}