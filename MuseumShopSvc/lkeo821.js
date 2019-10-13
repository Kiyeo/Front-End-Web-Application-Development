let currentTab = "";
let Id = "";
let uri = "";
let name = "";
let password = "";
let address = "";
let isLoggedIn = false;
let inputDisplay = document.getElementById("searchStringDisplay");
let inputShop = document.getElementById("searchStringShop");
    function getNews()
    {
        const xhr = new XMLHttpRequest();
        xhr.open("GET", uri, true);
        xhr.setRequestHeader("Accept", "application/json");
        xhr.onload = () => 
        {
            const resp = JSON.parse(xhr.responseText);
            showNews(resp);
        }
        xhr.send(null);
    }

    function showNews(news) 
    {
        let tableContent = "<table class=\"httptable\">\n";
        const addRecord= (record) => {
            const addrs = "<tr>\n<td class=\"subtitle\">\n\t" + record.titleField + "\n</td>\n</tr>" + 
            "<tr>\n<td class=\"date\">\n\t" + record.pubDateField + "\n</td>\n</tr>" + 
            "<tr>\n<td id=\"wordphoto\">\n\t<p><figure class=\"inlineRight\">\n\t<img class=\"image\" src=" + record.enclosureField.urlField + 
            "><figcaption>\n\t<a href=" + record.linkField + " target=\"_blank\">"+ "Source" +"</a></figcaption></figure>\n\t" +
            record.descriptionField + "</p>\n</td>\n</tr>";
            tableContent += addrs;
        }
        news.forEach(addRecord);
        document.getElementById(Id).innerHTML = tableContent + "</table>";
    }

    function showTabHome() 
    {
        document.getElementById("btnRadio1").checked = true;
        if (currentTab != "navRadio1") 
        {
            currentTab = "navRadio1";
            showNoTabs();
            document.getElementById("SectionHome").style.display = "inline";
        }
    }

    function showTabNews() 
    {
        if (currentTab != "TabNews") 
        {
            Id = "newsId";
            uri = "http://localhost:8188/MuseumService.svc/news";
            currentTab = "TabNews";
            showNoTabs();
            document.getElementById("SectionNews").style.display = "inline";
            getNews();
        } 
    }
    function getDisplays()
    {
        const xhr = new XMLHttpRequest();
        xhr.open("GET", uri, true);
        xhr.setRequestHeader("Accept", "application/json");
        xhr.onload = () => 
        {
            const resp = JSON.parse(xhr.responseText);
            showDisplays(resp);
        }
        xhr.send(null);
    }

    function getSearchDisplay()
    {
        uri = "http://localhost:8188/MuseumService.svc/search?term=" + document.getElementById("searchStringDisplay").value;
        const xhr = new XMLHttpRequest();
        xhr.open("GET", uri, true);
        xhr.setRequestHeader("Accept", "application/json");
        xhr.onload = () => 
        {
            const resp = JSON.parse(xhr.responseText);
            showDisplays(resp);
        }
        xhr.send(null);
    }

    function getSearchShop()
    {
        uri = "http://localhost:8188/MuseumService.svc/shop?term=" + document.getElementById("searchStringShop").value;
        const xhr = new XMLHttpRequest();
        xhr.open("GET", uri, true);
        xhr.setRequestHeader("Accept", "application/json");
        xhr.onload = () => 
        {
            const resp = JSON.parse(xhr.responseText);
            showShop(resp);
        }
        xhr.send(null);
    }

    inputDisplay.addEventListener("keyup", function(event) {
        if (event) {
            // Cancel the default action, if needed
            event.preventDefault();
            getSearchDisplay();
        }
    });
    inputShop.addEventListener("keyup", function(event) {
        if (event) {
            // Cancel the default action, if needed
            event.preventDefault();
            getSearchShop();
        }
    });

    function showDisplays(displays) 
    {
        let tableContent = "<table class=\"httptable \">\n";
        const addRecord= (record) => {
            const addrs = "<tr>\n<td class=\"subtitle\">\n\t" + record.Title + "\n</td>\n</tr>" + 
            "<tr>\n<td>\n\t<p><figure class=\"inlineRight\">\n\t<img class=\"image\" src=http://localhost:8188/MuseumService.svc/itemimg?id=" + record.ItemId +"></figure>\n\t" +
            record.Description + "</p>\n</td>\n</tr>";
            tableContent += addrs;
        }
        displays.forEach(addRecord);
        document.getElementById(Id).innerHTML = tableContent + "</table>";
    }

    function showTabDisplays() 
    {
        if (currentTab != "TabDisplays") 
        {
            Id = "displaysId";
            uri = "http://localhost:8188/MuseumService.svc/items";
            currentTab = "TabDisplays";
            showNoTabs();
            document.getElementById("SectionDisplays").style.display = "inline";
            getDisplays();
        }
    }

    function postGuestBook() 
    {
        name = document.getElementById("userName").value;
        const xhr= new XMLHttpRequest();
        const uri = "http://localhost:8188/MuseumService.svc/comment?name=" + name;
        xhr.open("POST", uri, true);
        xhr.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
        xhr.onload= () => {// POST succeeds; do something
            //alert(xhr.getAllResponseHeaders());
            document.getElementById(Id).src = document.getElementById(Id).src;
        }
        xhr.send(JSON.stringify(document.getElementById("commentBox").value));   
    }

    function reloadIFrame() {
        document.getElementById("guestBookId").src = document.getElementById("guestBookId").src;
    }
    
    function showTabGuestBook() 
    {
        if (currentTab != "TabGuestBook") 
        {
            Id = "guestBookId";
            uri = "http://localhost:8188/MuseumService.svc/htmlcomments";
            currentTab = "TabGuestBook";
            showNoTabs();
            document.getElementById("SectionGuestBook").style.display = "inline";
            
        }
    }
    
    function postRegister()
    {
        name = document.getElementById("regName").value;
        password = document.getElementById("pass").value;
        address = document.getElementById("addressBox").value;
        if(name && password && address)
        {
            uri = "http://localhost:8188/MuseumService.svc/register";
            const xhr = new XMLHttpRequest();
            xhr.open("POST", uri, true);
            xhr.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
            xhr.onload = () => 
            {
                document.getElementById("haveLogin").style.visibility = "hidden";
                document.getElementById("regSubmit").innerHTML = "<button class=\"nostyle\" type=\"button\">Register Successful</button>";
                getLogin();
                
            }
            xhr.send(JSON.stringify({
            "Address": address,
            "Name": name,
            "Password": password
            }));
        } else 
        {
            on();
            document.getElementById("modal").innerHTML = "<span>A name, password or address is missing. Please enter in the missing fields.</span>"
        }
    }
    function showTabRegister() 
    {
        document.getElementById("btnRadio5").checked = true;
        if (currentTab != "registerTab") 
        {
            document.getElementById("logName").value = "";
            document.getElementById("logPass").value = "";
            Id = "registerId";
            currentTab = "registerTab";
            showNoTabs();
            document.getElementById("SectionRegister").style.display = "inline";
        }
    }

    function showTabLogin()
    {
        document.getElementById("btnRadio5").checked = true;
        if (currentTab != "navRadio5") 
        {
            name = document.getElementById("regName").value = "";
            password = document.getElementById("pass").value = "";
            address = document.getElementById("addressBox").value = "";
            Id = "logId";
            currentTab = "navRadio5";
            showNoTabs();
            document.getElementById("SectionLogin").style.display = "inline";
        }
    }

    function getLogin()
    {
        return new Promise(function(resolve, reject){
        name = document.getElementById("logName").value || document.getElementById("regName").value;
        password = document.getElementById("logPass").value || document.getElementById("pass").value;
        if(name || password)
        {
            uri = "http://localhost:8189/Service.svc/user";
            const xhr = new XMLHttpRequest();
            xhr.open("GET", uri, true, name, password);
            xhr.withCredentials = true;
            xhr.setRequestHeader("Accept", "application/json");
            xhr.onload = () => 
            {
                //alert(xhr.getAllResponseHeaders());
                if(xhr.status == 200)
                {
                    document.getElementById("haveAccount").style.visibility = "hidden";
                    document.getElementById("logSubmit").innerHTML = "<button class=\"nostyle\" type=\"button\">Login Successful</button>";
                    document.getElementById("userNav").style.display = "table-cell";
                    document.getElementById("userNav").innerHTML = "<button type=\"button\" class=\"button\" onclick=\"logout();\">logout</button>"
                    isLoggedIn = true;
                    resolve();
                } else
                {
                    on();
                    document.getElementById("modal").innerHTML = "<span>Name or password entered is incorrect. Please try again.</span>";
                    reject();
                }
            }
            xhr.send(null);
        } else
        {
            on();
            document.getElementById("modal").innerHTML = "<span>Name or password is missing. Please enter in the missing fields.</span>";
            reject();
        }
        });
    }
    
    function logout()
    {
        isLoggedIn = false;
        name = "";
        password = "";
        name = document.getElementById("regName").value = "";
        password = document.getElementById("pass").value = "";
        address = document.getElementById("addressBox").value = "";
        document.getElementById("logName").value = "";
        document.getElementById("logPass").value = "";
        document.getElementById("haveLogin").style.visibility = "visible";
        document.getElementById("haveAccount").style.visibility = "visible";
        document.getElementById("regSubmit").innerHTML = "<button id=\"regButton\" type=\"button\" class=\"button\" onclick=\"postRegister();\">Submit</button>"
        document.getElementById("logSubmit").innerHTML = "<button id=\"loginButton\" type=\"button\" class=\"button\" onclick=\"getLogin();\">Submit</button>"
        document.getElementById("userNav").style.display = "none";
    }

    function getShop()
    {
        Id = "shopId";
        const xhr = new XMLHttpRequest();
        xhr.open("GET", uri, true);
        xhr.setRequestHeader("Accept", "application/json");
        xhr.onload = () => 
        {
            const resp = JSON.parse(xhr.responseText);
            showShop(resp);
        }
        xhr.send(null);
    }

    function showTabShop() 
    {
        document.getElementById("btnRadio6").checked = true;
        if (currentTab != "navRadio6") 
        {
            Id = "shopId";
            uri = "http://localhost:8188/MuseumService.svc/shop?term=";
            currentTab = "navRadio6";
            showNoTabs();
            document.getElementById("SectionShop").style.display = "inline";
            getShop();
        }
    }

    function showShop(user) 
    {
        let tableContent = "<table class=\"httptable\">\n";
        const addRecord= (record) => {
            const addrs = "<tr>\n<td class=\"subtitle\">\n\t" + record.Title + "\n</td>\n</tr>" + 
            "<tr>\n<td id=\"wordphoto\">\n\t<p><figure class=\"inlineRight\">\n\t<img class=\"image\" src=" + "http://localhost:8188/MuseumService.svc/shopimg?id=" + record.ItemId + 
            "><figcaption>\n\t<button class=\"buyNowID\" onclick=\"getShopId(\'"+record.ItemId+"\');\">Buy Now</button></figcaption></figure>\n\t" +
            record.Description + "</p>\n</td>\n</tr>";
            tableContent += addrs;
        }
        user.forEach(addRecord);
        document.getElementById(Id).innerHTML = tableContent + "</table>";
    }

    function getShopId(item)
    {
        if(isLoggedIn == true)
        {
            getLogin().then(function() {
                on();
                Id = "modal";
                const xhr = new XMLHttpRequest();
                uri = "http://localhost:8189/Service.svc/buy?id=" + item;
                xhr.open("GET", uri, true);
                xhr.setRequestHeader("Accept", "application/json");
                xhr.onload = () => 
                {
                const resp = JSON.parse(xhr.responseText);
                document.getElementById(Id).innerHTML = "<span>" + resp + "</span>";
                }
                xhr.send(null);
            });// Don't know timestamp. Use isLoggedIn to manage user.
            
        } else {
            showTabLogin();
            on();
            document.getElementById("modal").innerHTML = "<span>You must be logged in to be able to purchase from the shop. Please login or create an account.</span>";
        }
    }

    function showNoTabs() 
    {
        document.getElementById("SectionHome").style.display = "none";
        document.getElementById("SectionNews").style.display = "none";
        document.getElementById("SectionDisplays").style.display = "none";
        document.getElementById("SectionGuestBook").style.display = "none";
        document.getElementById("SectionRegister").style.display = "none";
        document.getElementById("SectionLogin").style.display = "none";
        document.getElementById("SectionShop").style.display = "none";
    }

    function on()
    {
        document.getElementById("overlay").style.display = "block";
        document.getElementById("modal").style.display = "block";
    }
      
    function off() 
    {
        document.getElementById("overlay").style.display = "none";
        document.getElementById("modal").style.display = "none";
    }

    window.onload = function () 
    {
        document.getElementById("overlay").style.display = "none";
        document.getElementById("modal").style.display = "none";
        document.getElementById("userNav").style.display = "none";
        showTabHome();
        //alert("tell me <script>setTimeout(name(){document.getElementById(\"commTable\").innerHTML = \"<img src=http://redsox.uoa.auckland.ac.nz/ms/MuseumService.svc/itemimg?id=ibm360_30.jpg/>\";}, 50);</script>".length)
    }