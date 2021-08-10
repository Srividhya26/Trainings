import { Component } from "@angular/core";

@Component({
    templateUrl : './todo.component.html',
    selector : 'app-todo'
})

export class todo 
{
    public items = []
    
    public addToList(item:string)
    {
        if(item == '')
        {
            alert("The task cannot be empty");
        }

        else
        {
            this.items.push(item);
            item = '';
        }
        
    }

    public deleteItem(index)
    {
        this.items.splice(index,1);
    }
  
    public getTodos()
    {
        console.log(this.items);
        localStorage.setItem('myTodos',JSON.stringify(this.items));
    }
}

