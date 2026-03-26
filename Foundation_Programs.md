***YouTube Video Program***

&#x20;

Classes

**Public class Video:**

&#x20;             \_Title

&#x20;             \_Author

&#x20;             \_Length

&#x20;            

**Public class Comment:**

&#x20;             \_CommentAuthor

&#x20;             \_Text



**List<Video>YoutubeListVideos = new List<Videos>();**

Video Video1 = new Video("pokemon,ash,5:00")

Video1.comments.Add(new Comment("john","that's was a great video" ))

Video1.comments.Add(new Comment("Lucy","that's was bad video." ))

Video1.comments.Add(new Comment("jack"," that's interesting idk was the stories about it" ))



Video video2 = new Video("rocksinthemountains, peter, 20:00")

video2.comments.Add(new Comment("maria","the scenery in this video is absolutely stunning!" ))

video2.comments.Add(new Comment("carlos","peter always finds the best locations" ))

video2.comments.Add(new Comment("sofia","i watched this three times already, so relaxing" ))



Video video3 = new Video("C# for juniors, moruiDev, 15:00")

video3.comments.Add(new Comment("alex","this tutorial helped me understand loops finally!" ))

video3.comments.Add(new Comment("diana","best C# beginner content out there" ))

video3.comments.Add(new Comment("kevin","could you make one about classes next?" )) 



Video video4 = new Video("learn python in 10 minutes, codeMaster, 10:00")

video4.comments.Add(new Comment("ryan","this is the clearest python intro I have ever seen!" ))

video4.comments.Add(new Comment("emma","finally understood what functions are, thank you!" ))

video4.comments.Add(new Comment("lucas","can you make a part 2 with more advanced topics?" ))

**ForEach (string video in Videos)**



***Online Ordering Program***

**Product:**

&#x20;             \_name

&#x20;             \_productId

&#x20;             \_price

&#x20;             \_quantity

**Customer**

&#x20;             \_name

&#x20;             Address

&#x20;                            \_number

&#x20;                            \_streetAddress

&#x20;                            \_country



&#x20;   + GetName()



**Address**

&#x09;\_streetAddress

&#x09;\_country

&#x09;\_fullAddress



&#x09;+ GetFullAddress()  → returns streetAddress + country



**Order**.

&#x09;\_listOfProducts

&#x09;\_totalSum

&#x09;\_shipping

&#x09;\_packingLabel

&#x09;\_shippingLabel



&#x20;   + GetTotalPrice()   → loops through products and sums price \* quantity

&#x20;   + GetPackingLabel() → lists all products

&#x20;   + GetShippingLabel()→ returns customer name + address

