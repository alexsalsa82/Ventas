import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MioComponent } from './mio.component';

const routes: Routes = [
    {
        path: '', component: MioComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class MioRoutingModule {
    
}