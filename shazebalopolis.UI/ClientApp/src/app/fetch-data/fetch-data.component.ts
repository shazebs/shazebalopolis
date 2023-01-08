import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class FetchDataComponent {
  private readonly url = 'https://shazebsapi.azurewebsites.net/api'; 
  //private readonly url = 'https://localhost:7068/api'; 

  constructor(
    private http: HttpClient
  ) { }


  // Get Bearer token function
  getToken(): string {
    let spliceEnd = localStorage.getItem('Token')?.length as number;
    let token = localStorage.getItem('Token')?.substring(1, spliceEnd - 1);
    if (token !== undefined) {
      return token;
    } else return 'no token exists';
  }


  // GET all tweets 
  async GetAllTweets(): Promise<Observable<Tweet[]>> {
    return this.http.get<Tweet[]>(`${this.url}/tweets`,
      { headers: new HttpHeaders().set('Authorization', 'Bearer ' + this.getToken()) });
  }


  // POST tweet
  CreateNewTweet(entity: Tweet): Observable<Tweet> {
    return this.http.post<Tweet>(`${this.url}/tweets`, entity,
      { headers: new HttpHeaders().set('Authorization', 'Bearer ' + this.getToken()) });
  }
}


// Interface models

export interface Tweet {
  TweetId?: number
  Content: string
  Username: string
}
