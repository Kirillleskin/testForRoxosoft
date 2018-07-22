import { IProductModel } from './product.model';

export interface IOrderModel {
	id: number;
	date: Date;
	status: number;
	total: number;
}