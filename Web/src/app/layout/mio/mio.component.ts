import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mio',
  templateUrl: './mio.component.html',
  styleUrls: ['./mio.component.scss']
})
export class MioComponent implements OnInit {
  mia:number=0;
  constructor() { 
    this.mia =1;
    
  }

  aumentar():number{
    return this.mia+=1;
  }
  ngOnInit() {
  }

}
