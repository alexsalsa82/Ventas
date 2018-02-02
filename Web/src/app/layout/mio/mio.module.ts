import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MioRoutingModule } from './mio-routing.module';
import { MioComponent } from './mio.component';

@NgModule({
  imports: [
    CommonModule,
    MioRoutingModule
  ],
  declarations: [MioComponent]
})
export class MioModule {
  
    
 }
