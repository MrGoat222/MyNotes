//Laver bogen
Book book = new Book("Programming notes");
List<Chapter> chapters = new List<Chapter>();

//Definere kapiteler
Chapter variablesChapter = new Chapter("Variables");
Chapter LoopsChapter = new Chapter("Loops");

//Laver et nyt kaptitel
chapters.Add(variablesChapter);
chapters.Add(LoopsChapter);
//Beskriver liste hvor du kan lave nogle sider.
List<Page> variablesPages = new List<Page>(){
    new Page(MyNotes.VariablesPageOne),
    new Page(MyNotes.VariablesPageTwo)
};
List<Page> LoopsPages = new List<Page>(){
    new Page(MyNotes.LoopsPageOne),
    new Page(MyNotes.LoopsPageTwo)
};

variablesChapter.Pages = variablesPages;
book.Chapters = chapters;
LoopsChapter.Pages = LoopsPages;
//starter bogen.
book.Start();



// Ved brug af constructor chaining kan vi gøre ovenstående mere læsbart:
Book book2 = new Book("Programming notes", new List<Chapter>(){
    new Chapter("Vars", new List<Page>(){
        new Page(MyNotes.VariablesPageOne),
        new Page(MyNotes.VariablesPageTwo)
    }),
    new Chapter("Unity", new List<Page>(){
        //new Page(MyNotes.UnityPageOne),
        //new Page(MyNotes.UnityPageTwo),
        //new Page(MyNotes.UnityPageThree)
    })
});

//book2.Start();
