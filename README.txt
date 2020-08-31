Made using Visual Studio 2019. 


Why did I choose to make MASH?
------------------------------
I decided to make a computerised version of MASH, the school break-time "predict your future" game (https://mashplus.com/how-to-play-mash/)
because I'd be able to demonstrate object oriented programming and also get to work with iterating through elements in a list or array that's been populated
by player input so it feels personalised.

It's an interactive game that I remember playing at school during lunch breaks for a laugh and I thought it would work well as a console app.
It's interesting in that the selection/eradication method of certain elements under each "category" such as Food or Abode is counted traditionally using a number 
obtained from drawing a spiral on a piece of paper and bisecting it with a line and counting all points that touch. 

When playing on a piece of paper it is easy to see the number of options under each "category" and crossing off every nth 
(number chosen by spiral) option. However, while programming, unless stating and enforcing a precise limit on number of input options *or* accounting for 
varying sized lists in a complex way, it's very difficult to count through all categories and their input lists when there are differing sizes of lists. 
The problem here is that if one category only has 2 inputs and another has 7, counting through all inputs in all categories may yield a result of having eradicated
ALL inputs under a category (most likely the category with only 2 inputs compared to the 7), renderering that one category empty, resulting in the inability to 
"predict your future" because one category has been omitted.

Therefore, for the selection algorithm I've used a different method where the program will cycle through one category list over and over (whatever the size of the list) 
and however many times it needs to, in order to meet the nth count (chosen by spiral diagram). The list element where the nth count lands during the cycle will be the
one selected for the purpose of the game. 

Whilst not technically accurate to an original game of MASH, it's a way that a chosen number can be used to select a certain element from a list in a given category.
 

