import { Component, OnInit } from '@angular/core';
import { OrdersService } from '../../core/services/order.service';
import { IOrderModel } from '../../core/models/order.model';
import { IProductModel } from '../../core/models/product.model';

@Component({
	selector: 'app-orders',
	templateUrl: './orders.component.html',
	styleUrls: ['./orders.component.scss']
})

export class OrdersComponent implements OnInit {

	public serverErrors: any;

	public selectedOrder: IOrderModel;
	public orders: IOrderModel[];
	public orderProducts: IProductModel[];
	public _e: any;

	public QtySumm: number;
	public PriceSumm: number;
	public TotalSumm: number;

	constructor(private _ordersService: OrdersService) { }

	public ngOnInit() {
		this._ordersService.getOrders().subscribe((data: IOrderModel[]) => this.orders = data);
	}

	public select(e: any, order: IOrderModel) {
		this.selectedOrder = order;

		if (this.selectedOrder) {
			this._ordersService.getProducts(this.selectedOrder.id)
				.subscribe((data: IProductModel[]) => {
					this.orderProducts = data;
					this.QtySumm = this.orderProducts.map(x => x.qty).reduce((a, b) => a + b);
					this.PriceSumm = this.orderProducts.map(x => x.price).reduce((a, b) => a + b);
					this.TotalSumm = this.orderProducts.map(x => x.total).reduce((a, b) => a + b);
				});

		}

		if (this._e) {
			this._e.classList.remove('clicked');
		}

		e.classList.toggle('clicked');
		this._e = e;
	}
}
