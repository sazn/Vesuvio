$(() => {
    var connection = new signalR.HubConnectionBuilder().withUrl("/signalrServer").build();
    connection.start();
    connection.on("LoadRosters", function (name) {
        //$("#tableBody").remove();       
        LoadRoasterData(name);   
    })

    function LoadRoasterData(name) {
        debugger;
        var roasterName = name == undefined ? "" : name;
        var tr = '';
        $.ajax({

            url: '/Roster/GetRoaster',
            method: 'GET',
            success: (result) => {
                $.each(result, (k, v) => {
                    tr += `<tr> 
                            <td>${v.FullName}</td>
                            <td>${v.GroupName}</td>
                            <td>${v.Age}</td>
                        </tr>`
                
                })
                $("#tableBody").html(tr);

                if (roasterName != ""){    
                    $("#getCodeModal").modal("toggle");
                    $("#success-message").html(name + " " + "Joined the group");
                 }         
                
            },
            error: (error) => {
                console.log(error)
            }
        });

    }
})
