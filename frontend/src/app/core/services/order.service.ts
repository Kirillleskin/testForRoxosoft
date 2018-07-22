import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators';

import { ResponseErrorHandlerService } from '../../shared/services/response-error-handler-service';
import { ConfigService } from '../../shared/services/config.service';
import { HttpHeaders, HttpClient, HttpRequest, HttpResponse } from '@angular/common/http';
import { IOrderModel } from '../models/order.model';
import { IProductModel } from '../models/product.model';

@Injectable()
export class OrdersService {

	private headers: HttpHeaders;
	private options: Object;

	constructor(
		private http: HttpClient,
		private _responseErrorHandlerService: ResponseErrorHandlerService,
		private _configService: ConfigService
	) {
		this.headers = new HttpHeaders();
		this.headers.set('Accept', 'application/json');
		this.headers.set('Content-Type', 'application/json');
		this.options = { headers: this.headers };
	}

	public getOrders(): Observable<IOrderModel[]> {
		return this.http.get(`${this._configService.serverApiUrl}/api/orders`, this.options)
			.pipe(catchError(this._responseErrorHandlerService.handleHttpRequestErrors));
	}

	public getProducts(orderId: number): Observable<IProductModel[]> {
		return this.http.get(`${this._configService.serverApiUrl}/api/orders/${orderId}/products`, this.options)
			.pipe(catchError(this._responseErrorHandlerService.handleHttpRequestErrors));
	}
}