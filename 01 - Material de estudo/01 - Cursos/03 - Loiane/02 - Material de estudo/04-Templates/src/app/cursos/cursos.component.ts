import { Component } from '@angular/core';

@Component({
  selector: 'app-cursos',
  templateUrl: './cursos.component.html',
  styleUrl: './cursos.component.css'
})
export class CursosComponent {
  
   link: string;

   cursos: string[] = ['Java', 'Ext JS', 'Angular']; 

   constructor()
   {
    this.link = "http://loiane.training "
   }
}
