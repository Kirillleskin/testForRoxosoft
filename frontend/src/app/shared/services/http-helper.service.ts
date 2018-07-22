import { Injectable } from '@angular/core';
import { HttpParams } from '@angular/common/http';

@Injectable()
export class HttpHelperService {

	public getHttpParams(paramsObject: any) {
		let httpParams = new HttpParams();
		Object.keys(paramsObject).forEach(function (key) {
			httpParams = httpParams.append(key, paramsObject[key]);
		});
		return httpParams;
	}
}
