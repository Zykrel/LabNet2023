import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperslistComponent } from './components/shipperslist/shipperslist.component';
import { ShipperscreateComponent } from './components/shipperscreate/shipperscreate.component';
import { ShippersupdateComponent } from './components/shippersupdate/shippersupdate.component';
import { ShippersdeleteComponent } from './components/shippersdelete/shippersdelete.component';



@NgModule({
  declarations: [
    ShipperslistComponent,
    ShipperscreateComponent,
    ShippersupdateComponent,
    ShippersdeleteComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ShippersModule { }
