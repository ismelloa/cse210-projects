using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var wordsToHide = _words.Where(word => !word.IsHidden())
                                .OrderBy(x => random.Next())
                                .Take(count);
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference}\n" + string.Join(' ', _words.Select(word => word.GetRenderedText()));
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}



// Suppose we have a scripture with the following words:

// plaintext
// Copy code
// "God so loved the world"
// Initially, none of the words are hidden. Let's simulate the action of HideRandomWords(2) on this scripture, where we want to hide 2 random words.

// Filtering non-hidden words:

// Initially, the wordsToHide collection will contain all words because none are hidden.
// After applying the Where clause, it will filter out any words that are already hidden. Since none are hidden initially, all words are included.
// Shuffling:

// The OrderBy method shuffles the filtered words randomly. For simplicity, let's say it shuffles them to: "world", "God", "loved".
// Taking count:

// The Take(2) method selects the first 2 words from the shuffled list. Let's say it selects "world" and "God".
// Hiding selected words:

// The foreach loop iterates over the selected words ("world" and "God").
// For each word, the Hide() method is called, marking them as hidden.
// After the action of HideRandomWords(2):

// plaintext
// Copy code
// "____ so ____ the world"
// In this example, "world" and "God" were randomly selected and hidden, resulting in their replacement with underscores.