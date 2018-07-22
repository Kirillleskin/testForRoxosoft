import { Observable } from 'rxjs';
import { ApplicationError } from '../../core/models/server-error';

export class ResponseErrorHandlerService {

	// Метод для обработки ошибок http-запросов
	public handleHttpRequestErrors(response: any) {
		return Observable.throw(response);
	}

	public processServerErrors(data: any): any {

		// let serverError: ApplicationError;

		// if (data != null && data.error != null && data.error.message != null && data.error.message.length > 0) {
		// 	serverError = new ApplicationError(data.error.message);
		// } else {
		// 	serverError = new ApplicationError('Произошла ошибка во время запроса. Попробуйте снова позднее.');
		// }
		console.error(data);
		return data;
	}
}
