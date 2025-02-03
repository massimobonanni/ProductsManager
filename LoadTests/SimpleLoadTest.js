// Import the http module to make HTTP requests. From this point, you can use `http` methods to make HTTP requests.
import http from 'k6/http';

// Import the sleep function to introduce delays. From this point, you can use the `sleep` function to introduce delays in your test script.
import { sleep } from 'k6';

import { randomIntBetween } from 'https://jslib.k6.io/k6-utils/1.2.0/index.js';

export const options = {
    // Define the number of iterations for the test
    //iterations: 10,
    // Define the duration of the test
    duration: '300s',
    // Define the number of virtual users for the test
    vus: 10
  };

// The default exported function is gonna be picked up by k6 as the entry point for the test script. It will be executed repeatedly in "iterations" for the whole duration of the test.
export default function () {
    // Make a GET request to the target URL
    http.get('https://productsmanagerfe.azurewebsites.net/');
  
    sleep(Math.random() * 10);
}