from modelscope.pipelines import pipeline
from modelscope.utils.constant import Tasks
from modelscope.outputs import OutputKeys

img = 'https://modelscope.oss-cn-beijing.aliyuncs.com/test/images/dogs.jpg'
test_pipeline = pipeline(Tasks.bad_image_detecting, 'damo/cv_mobilenet-v2_bad-image-detecting')
result = test_pipeline(img)
print(result)