import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ShipperslistComponent } from './components/shipperslist/shipperslist.component';
import { ShipperscreateComponent } from './components/shipperscreate/shipperscreate.component';
import { ShippersupdateComponent } from './components/shippersupdate/shippersupdate.component';
import { ShippersdeleteComponent } from './components/shippersdelete/shippersdelete.component';
import { ReactiveFormsModule } from '@angular/forms';


export const routes: Routes = [{
  path: '',
  component: ShipperslistComponent
}, {
  path: 'create',
  component: ShipperscreateComponent
}, {
  path: 'update',
  component: ShippersupdateComponent
}, {
  path: 'delete',
  component: ShippersdeleteComponent
}]

@NgModule({
  declarations: [
    ShipperslistComponent,
    ShipperscreateComponent,
    ShippersupdateComponent,
    ShippersdeleteComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    ReactiveFormsModule
  ]
})
export class ShippersModule { }
