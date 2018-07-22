import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutRoutingModule } from './layout-routing.module';

import { LayoutComponent } from './layout.component';
import { OrdersComponent } from './orders/orders.component';
import { OrdersService } from '../core/services/order.service';

@NgModule({
	imports: [
		CommonModule,
		LayoutRoutingModule
	],
	declarations: [
		LayoutComponent,
		OrdersComponent
	],
	providers: [
		OrdersService
	]
})
export class LayoutModule { }
