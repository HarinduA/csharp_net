import requests

def subscribe_to_job(job_id, worker_id):
    url = "https://www.fulltask.xyz/subscribe.php"
    parameters = {
        "job": job_id,
        "worker": worker_id
    }
    
    response = requests.post(url, data=parameters)
    
    if response.status_code == 200:
        print("Subscription successful.")
    else:
        print("Subscription failed. Error code:", response.status_code)

def main():
    job_id = "70d616b8aa68"
    worker_id = "26794d27"
    
    subscribe_to_job(job_id, worker_id)

if __name__ == "__main__":
    main()
