let url = 'http://carserviceboard.somee.com/api/Users/Login?password=SSSr4nk&username=qweKing';
let response = await fetch(url);

let commits = await response.json();

alert(commits[0].author.login);