import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LayoutComponent } from './layout.component';
import { OrdersComponent } from './orders/orders.component';

const routes: Routes = [
	{
		path: '', component: LayoutComponent,
		children: [
			{ path: '', redirectTo: 'orders', pathMatch: 'full' },
			{ path: 'orders', component: OrdersComponent, canActivate: [] },
		]
	}
];

@NgModule({
	imports: [RouterModule.forChild(routes)],
	exports: [RouterModule],
})

export class LayoutRoutingModule { }
